pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh '''cd src
dotnet-sdk.dotnet restore
dotnet-sdk.dotnet build'''
      }
    }

  }
}