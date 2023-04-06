
# 기록에 있는 commit 메시지 수정 ( 최대 3개로 지정 )
git rebase -i HEAD~3

# reword = 특정 커밋은 유지 하되, 커밋 메시지만 변경
# drop   = 특정 커밋을 삭제합니다.
# git rebase로 commit메시지를 변경 후 git push -f 로 강제 push를 해줘야 한다.


# 메시지 기록을 개수 제한으로 보기
git log -i HEAD~3
=> 밑에서 3개위로 기록 보기
=> log가 5개라면 2개 보여줌

git log -i HEAD~2
=> 밑에서 2개위로 기록 보기
=> log가 5개라면 3개 보여줌


# 특정 커밋 자체를 삭제하는 경우 명령어 ( 웬만해서 개인 프로젝트에서만 사용 )
=> git rebase -i HEAD~3
=> drop