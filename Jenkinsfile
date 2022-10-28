pipeline {
    agent any

    stages {
        stage('Build and Publish') {
            steps {
                echo 'building and publishing....'
                script {
                    docker.withRegistry( 'https://hub.docker.com/flaviomalto', 'local-docker-hub' ) {
                        def dockerImage = docker.build("flaviomalto/dockerhub:${env.BUILD_ID}")
                        dockerImage.push("$BUILD_NUMBER")
                        dockerImage.push('latest')
                    }
                }
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }        
    }
}