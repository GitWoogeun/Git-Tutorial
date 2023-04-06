
# Merge를 하는 과정에서 다양한 충돌에 대해서 배워보도록 하겠습니다.
# 일반적으로 서로 다른 브랜치에서 하나의 동일한 파일을 수정을 할때 
# merge를 하면 충돌이 발생한다 이를 해결하는 방법을 알아보도록 하자


# master 브랜치와 develop 브랜치가 서로 충돌 했을 때 나오는 코드
<<<<<<< HEAD
   return a / b # 주석     // 현재 master 브랜치에서 수정된 내용
=======
   return a / b           // 현재 develop 브랜치에서 수정된 내용
>>>>>>> develop

# 두개의 소스코드중 하나를 지운 다음에 최종적으로 수정된 내용을 
# git remoteRepository에 올리면 된다.

[remoteRepository에 올릴 소스]
return a / b # 주석     // 현재 master 브랜치에서 수정된 내용

# 1. git add . 
# 2. git commit -m"수정완료" 
# 3. git push