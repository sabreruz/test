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
                    //bat "start /B C:/final/Application/KeyboardWarIII.exe"
                    bat "start /B C:/gittest/LAB2/Robotiive_runner.exe SEP firstTask"
                }
                //bat "start /B C:/final/Application/KeyboardWarIII.exe"
            }
        }
    }
    post{
        always{
            echo 'always say goodbay'
        }
    }
}
