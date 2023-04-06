
# 이미 작성된 Git Commit의 날짜와 시간 변경 방법을 알아보자

# 특정 커밋을 수정 하고 싶다면 git rebase를 사용
git rebase 


# 특정 커밋 날짜 수정하기
git rebase -i HEAD~3
1. git  수정 공간에 들어가서 edit으로 변경 후 나옴
2. GIT_COMMITER_DATE="변경하고 싶은 날짜"
   ex) GIT_COMMITER_DATE="Oct 1 10:00:00:00 2023 +0000" git commit --amend --no-edit --date "Oct 1 10:00:00:00 2023 +0000"
   -> 10월 1일 오전 10시로 변경