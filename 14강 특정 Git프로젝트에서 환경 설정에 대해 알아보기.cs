
# Git Config : 환경설정

# 현재 내 git의 환경설정에 대해서 보여주는 명령어
git config --list

# 전체 계정명 설정하기
git config --global user.name = dnrms47

# 전체 계정 이메일 설정하기
git config --global user.email = dnrms47@naver.com

# 모든 파일을 확인하는 명령
ls -all

# Home 디렉토리에서 해당 Git의 사용자 정보 보기 명령어
cat .gitconfig

# 기본 에디터 vi로 설정하기
git config --global core.editor vi

# 폴더 만들기
mkdir "생성할 폴더 명"

# 폴더 삭제
rmdir "삭제할 폴더 명"

# 해당파일 내용 출력
cat 파일
ex) cat test.txt

# 특정 파일 만들기
touch 파일명.파일확장자
ex)touch TestMemo.txt

# 특정 파일 삭제
rm 파일명.파일확장자
ex) rm TestMemo.txt

# 특정 프로젝트에서 사용자 이름 설정하기
해당 프로젝트로 이동 후 사용자 정보 입력
1. cd 특정 프로젝트 폴더 이동

2. git config user.name  woogeun
   git config user.email woogeun@naver.com

3. 이렇게 특정 프로젝트에서만 설정이 되었고 전체에서는 변경 되지는 않음
    git config --global user.name
    git config --global user.email


# 임의 파일 만드는 명령어
touch 파일명.파일확장자
ex) touch Example.txt
