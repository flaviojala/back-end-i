pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh 'docker run flaviomalto/dockerhub:latest'
                echo 'Building..'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}