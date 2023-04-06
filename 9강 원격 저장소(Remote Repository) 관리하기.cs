
# 원격 저장소란 네트워크 공간 어딘가에 존재하는 또 다른 컴퓨터를 원격 저장소로 사용할수있다.

# 현재 원격 저장소로 어떠한것이 등록이 되어 있는지 확인
=> git remote 

# 특정한 원격저장소의 자세한 정보를 확인 하는 명령어
=> git remote show origin

# 특정한 원격저장소를 등록하고자 한다면
=> git remote add test 등록할 remoteRepository의 주소
=> ex) git remote add test https://github.com/GitWoogeun/Java_JDK.git

# 원격저장소 전체 목록 확인
=> git remote -v

# 원격저장소의 이름을 바꾸고 싶을때 사용하는 명령어
=> git remote rename 기존이름 변경할이름
=> ex) git remote rename test temp

# 특정한 원격저장소의 기록을 확인하는 명령어
# master branch의 origin 원격 저장소 기록 확인
=> git log origin/master

# 특정한 원격저장소 합치기
=> git merge 합칠 원격저장소/합칠 원격저장소의 브랜치
=> ex) git merge origin/Master


# 특정한 원격저장소를 제거하고자 할떄 사용하는 명령어
=> git remote rm 삭제할 원격저장소
=> ex) git remote rm temp


# 삭제 후 제대로 삭제되었는지 확인
=> git remote -v
