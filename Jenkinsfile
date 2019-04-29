pipeline {
    agent any 
    stages {
        stage('Build') {
            steps {
                echo 'Build Starts!'
                bat "\"C:/Program Files/dotnet/dotnet.exe\" restore \"${workspace}/JenkinsDotnetSampleProject.sln\""
                bat "\"C:/Program Files/dotnet/dotnet.exe\" build \"${workspace}/JenkinsDotnetSampleProject.sln\""
                echo 'Build Ends'
            }
        }
		
		stage('Test') {
            steps {
                echo 'Test Starts!'
                bat "\"C:/Program Files/dotnet/dotnet.exe\" test \"${workspace}/RazorJenkinsDotnetSampleProject.sln\""
                echo 'Test Ends'
            }
        }
    }
}