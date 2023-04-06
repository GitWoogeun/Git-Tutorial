
#  git pull : 제일 최신의 remoteRepository와 나의 LocalRepository 맞추기
=> git pull
# 설명 : remoteRepository는 파일이 5개있고 나의 LocalRepository에는 3개가 있다.
#       최근에 2개의 파일이 추가가 되었다. 이걸 매번 clone을 할수없으니 pull 명령어를 사용하여
#       remoteRepository와 나의 LocalRepository의 시점을 맞추면 된다.


# git에 반영된 기록들을 확인하는 명령어
=> git log
=> git log후 빠져 나올려면 q를 누르면 된다.


# 현재 버전이 아닌 이전버전으로 돌아가 그 이후에 push된 내역들 삭제
=> git reset --hard "해쉬값"
=> ex) git reset --hard 40083d1364683d3107748fbeb112d7141c7708d5


# git reset -- hard "해쉬값"을 하고 나면 내 LocalRepository와 remoteRepository가 달라져서
# push를 할수가 없게 된다 하면 rejected 오류가 발생한다.
# 하지만 이를 강제적으로 push하는 방법이 있는데 git push -f를 하면 
# remoteRepository는 내 LocalRepository와 동일한 버전으로 변경된다.
=> git push -f


# soft : 돌아간 이후에도 이후의 내역들을 보관 구글링 해보기
# mixd : 구글링 하기


# 잘못된 메시지가 commit된 경우 변경하는 방법

