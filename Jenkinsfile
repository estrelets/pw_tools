pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh '''cd src
dotnet restore
dotnetn build'''
      }
    }

  }
}