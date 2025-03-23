pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                // 從GitHub拉取代碼
                git url: 'https://github.com/sabreruz/test.git', branch: 'main'
            }
        }
        
        stage('Install Frontend Dependencies') {
            steps {
                dir('frontend') {
                    // 安裝前端依賴
                    bat 'npm install'
                }
            }
        }
        
        stage('Start Services') {
            steps {
                // 使用環境變數防止Jenkins終止子進程
                withEnv(['JENKINS_NODE_COOKIE=dontKillMe']) {
                    parallel(
                        frontend: {
                            dir('frontend') {
                                bat 'start /B npm run dev'
                                echo "前端服務已啟動"
                            }
                        },
                        backend: {
                            dir('backend') {
                                bat 'start /B scripts/run-backend-pip.bat'
                                echo "後端服務已啟動"
                            }
                        }
                    )
                }
                
                // 等待一段時間確保服務啟動
                sleep(time: 30, unit: 'SECONDS')
                echo "前端和後端服務已啟動並在背景運行"
            }
        }
    }
    
    post {
        success {
            echo "Pipeline執行成功，前端和後端服務已啟動"
        }
        failure {
            echo "Pipeline執行失敗，請檢查日誌"
        }
    }
}
