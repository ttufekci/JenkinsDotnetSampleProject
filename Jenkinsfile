pipeline {
    agent any 
    stages {
        stage('Build') {
            steps {
                echo 'Build Starts!'
                bat "\"C:/Program Files/dotnet/dotnet.exe\" restore \"${workspace}/dotnetweb.csproj\""
                bat "\"C:/Program Files/dotnet/dotnet.exe\" build \"${workspace}/dotnetweb.csproj\""
                echo 'Build Ends'
            }
        }
    }
}