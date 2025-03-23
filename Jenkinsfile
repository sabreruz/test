pipeline{
    agent any
    stages{
        stage("first"){
            steps {
                echo 'hello world'
            }
        }
        stage("run test"){
            steps {
                echo 'run test'
                withEnv(['JENKINS_NODE_COOKIE=dontKillMe']) {
                    bat "start /B C:/gittest/test/Application/KeyboardWarIII.exe"
                }
            }
        }
    }
    post{
        always{
            echo 'always say goodbay'
        }
    }
}
