using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Elements;
using Pw.Serializer;
using Pw.Serializer.Plans;

namespace Pw.Tests.SerializerTests
{
    [TestClass]
    public class PlanBuilderTest
    {
        [TestMethod]
        public void SimplePlan()
        {
            var type = typeof(EquipmentAddon);
            var builder = new PlanBuilder();
            var plan = (ComplexPlan)builder.Build(type);


            var idPlanItem = plan.Childs[0] as PrimitivePlanItem;
            var namePlanItem = plan.Childs[1] as StringPlanItem;
            var numParamsPlanItem = plan.Childs[2] as PrimitivePlanItem;
            var param1PlanItem = plan.Childs[3] as PrimitivePlanItem;
            var param2PlanItem = plan.Childs[4] as PrimitivePlanItem;
            var param3PlanItem = plan.Childs[5] as PrimitivePlanItem;


            Assert.IsNotNull(idPlanItem);
            Assert.IsNotNull(namePlanItem);
            Assert.IsNotNull(numParamsPlanItem);
            Assert.IsNotNull(param1PlanItem);
            Assert.IsNotNull(param2PlanItem);
            Assert.IsNotNull(param3PlanItem);

            Assert.AreEqual(TypeCode.UInt32, idPlanItem.TypeCode);
            Assert.AreEqual(nameof(EquipmentAddon.Id), idPlanItem.Accessor.ToString());
        }


        [TestMethod]
        public void PlanWithArrayOfComplexProperties()
        {
            var type = typeof(WeaponEssence);
            var builder = new PlanBuilder();
            var plan = (ComplexPlan)builder.Build(type);

            var uniquesPlan = plan.Childs
                .Where(p => p is ArrayPlanItem)
                .Cast<ArrayPlanItem>()
                .FirstOrDefault(p => p.Accessor.ToString() == nameof(WeaponEssence.Uniques));

            Assert.IsNotNull(uniquesPlan);
            Assert.AreEqual(16, uniquesPlan.Childs.Count);
        }


        [TestMethod]
        public void PlanWithArrayOfTuples()
        {
            var type = typeof(ArmorEssence);
            var builder = new PlanBuilder();
            var plan = (ComplexPlan)builder.Build(type);

            var planText = plan.ToString();

            Assert.IsNotNull(plan);
        }

        [TestMethod]
        public void PlanWithDynamicSize()
        {
            var type = typeof(TalkProc);
            var builder = new PlanBuilder();
            var plan = (ComplexPlan)builder.Build(type);

            var planText = plan.ToString();

            Assert.IsNotNull(plan);
        }

    }
}
