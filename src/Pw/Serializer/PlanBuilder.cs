using System;
using System.Linq;
using System.Collections.Generic;
using Pw.Serializer.Plans;
using Pw.Serializer.ValueAccessors;

namespace Pw.Serializer
{
    public class PlanBuilder
    {
        public IPlanItem Build(Type type)
        {
            return CreateComplex(type, new RootObject(type.Name));
        }

        private IPlanItem CreatePlan(PropertyDescriptor descriptor, IValueAccessor accessor)
        {
            if (PrimitivePlanItem.IsPrimitive(descriptor.PropertyType))
            {
                return new PrimitivePlanItem(accessor, descriptor.PropertyType, descriptor.IsBigEndian);
            }

            if (StringPlanItem.IsString(descriptor.PropertyType))
            {
                return descriptor.IsDynamicSize
                    ? new StringPlanItem(accessor, descriptor.IsNameChar)
                    : new StringPlanItem(accessor, descriptor.IsNameChar, descriptor.Size);
            }

            if (TuplePlanItem.IsTuple(descriptor.PropertyType))
            {
                return CreateTuple(descriptor.PropertyType, accessor);
            }

            if (descriptor.IsArray)
            {
                var elementDescriptor = new PropertyDescriptor(descriptor.ElementType);

                if (descriptor.IsDynamicSize)
                {
                    var childPlan = CreatePlan(elementDescriptor, new RootObject(descriptor.ElementType.Name));
                    return new CollectionPlanItem(accessor, descriptor.PropertyType, childPlan);
                }
                else
                {
                    var elementsPlans = Enumerable.Range(0, descriptor.Size)
                        .Select(index => new ArrayValueAccessor(index))
                        .Select(arrayAccessor => CreatePlan(elementDescriptor, arrayAccessor))
                        .ToArray();

                    return new ArrayPlanItem(accessor, descriptor.PropertyType, elementsPlans);
                }
            }

            return CreateComplex(descriptor.PropertyType, accessor);
        }

        private IPlanItem CreateComplex(Type type, IValueAccessor accessor)
        {
            var descriptors = GetDescriptors(type);
            var plan = new List<IPlanItem>();

            foreach (var descriptor in descriptors)
            {
                var propertyValueAccessor = new PropertyValueAccessor(descriptor.PropertyInfo);
                var item = CreatePlan(descriptor, propertyValueAccessor);
                plan.Add(item);
            }

            return new ComplexPlan(plan, type, accessor);
        }

        private IPlanItem CreateTuple(Type tupleType, IValueAccessor accessor)
        {
            var childs = new List<IPlanItem>();

            foreach (var fieldInfo in tupleType.GetFields())
            {
                var tupleFieldAccessor = new TupleValueAccessor(fieldInfo);
                var descriptor = new PropertyDescriptor(fieldInfo.FieldType);
                var planItem = CreatePlan(descriptor, tupleFieldAccessor);

                childs.Add(planItem);
            }

            return new TuplePlanItem(accessor, tupleType, childs.ToArray());
        }

        internal static IPlanItem CreateReadLengthPlan()
        {
            return new PrimitivePlanItem(new RootObject("Length"), typeof(int), false); //todo check endian logic
        }


        private PropertyDescriptor[] GetDescriptors(Type type)
        {
            return type.GetProperties()
                .Select(p => new PropertyDescriptor(p))
                .OrderBy(d => d.Order)
                .ToArray();
        }
    }
}
