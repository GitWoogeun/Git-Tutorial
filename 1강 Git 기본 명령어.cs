# Git Version 확인 :
=> git --Version


# 환경설정
# GitHub의 이름 설정
=> git config --global user.name GitWoogeun


# GitHub의 이메일 설정
=> git config --global user.email dnrms47@naver.com


# GitBash에서 폴더 이동 ( Change Directory )
=> cd 


# LocalRepository 생성
# initialized empty Git repository in 생성된 위치
=> git init


# git clone : RemoteRepository와 LocalRepository 연결
#           : git clone을 할 시 .git 폴더 생성
=> git clone https://github.com/GitWoogeun/Git-Tutorial.git


# Local Repository  : 현재 내 컴퓨터의 git 폴더
# remote Repository : GitHub의 저장소


# git에 파일 추가
=> git add 파일명.파일확장자
=> ex) git add document.txt

# git에 모든 파일 add 하기
=> git add .


# git Repository에 저장
# 1 file change, 1 insertion(+) 정상적으로 저장됨
=> git commit -m "저장할 명칭을 적어 두면 된다." 


# LocalRepository에서 RemoteRepository로 파일 올리는 명령어
# commit을 진행하고 난 뒤 git push를 할 수 있음
=> git push


# 현재 remoteRepository의 저장소의 크기를 확인 하는 명령어
=> git count-objects -v


# ┌──────────────────────────
# │ ★★ 중요 ★★
# └──────────────────────────
# git은 한 remoteRepository당 5GB의 데이터 저장을 할 수 있다.
# 그렇지만 한번에 5GB는 못올리고 분할 압축으로 90MB로 지정해서
# remoteRepository로 올릴 수 있다.


