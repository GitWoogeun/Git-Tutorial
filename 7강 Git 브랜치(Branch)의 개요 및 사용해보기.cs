
# Git 브랜치(Branch) 사용하는 방법 :
이번 시간에는 깃(Git)에서 브랜치(Branch)를 사용하는 방법에 대해서 알아보도록 하겠습니다.
깃(Git)은 동시에 여러 개발자들이 프로젝트에서 각기 다른 기능을 개발할 수 있도록 브랜치(Branch)
기능을 제공합니다. 서로 다른 브랜치는 작업을 함에 있어서 서로에게 영향을 받지 않는다는 점에서
마음 놓고 서로 다른 개발 작업을 수행할 수 있습니다.;


# Branch 동작 과정
브랜치의 동작 과정은 다음과 같은 에시로 표햔할 수 있습니다.
기본적으로 Git 저장소를 만들면 자동으로 마스터(Master) 브랜치가 생성됩니다.
이 브랜치는 일반적으로 배포가 가능한 수준의 안정화된 버전을 포함하고 있습니다.

그래서 별도의 브랜치를 만들어 사용하고자 한다면 체크아웃(CheckOut) 명령어를 이용해야 합니다.

┌───────────────┐       
│ Master Branch │ =>    ( 개발지점 )   =>     ( 버그수정지점 )  =>   ( 배포 )     =>
└───────────────┘           ↘                       ↑                  ↑
                          ▼   ┌────────────────┐    ↑                  ↑
                          ▼   │ Develop Branch │ => => => => => => => ↑
                          ▼   └────────────────┘    ↑
                          ▼                         ↑
                          ▼   ┌────────────────┐    ↑
                          ▶  │ Develop Branch │ => ↑
                              └────────────────┘                              

# Branch 합치기
현재 우리는 배포 버전이 Master Branch에 있는 상황에서, 새로운 기능을 개발하고 있습니다.
새로운 기능은 Develop Branch에서 개발하고 있으며 이와 동시에 버그가 발견되어 빠르게 버그를
수정해야 하는 일이 발생 했다고 해봅시다. 이 때 버그 수정은 Bug Fix Branch에서 
진행하는 겁니다. 그리고 버그가 수정되는 대로 바로 Master Branch에 수정 내역을 합치고,
기능 또한 합쳐주어 결과적으로 새로운 배포 버전이 탄생하도록 개발을 진행하는 겁니다.

그러면 합치기(Merge)가 수행되기 전까지는 안정적으로 배포가 이루어지고 있다가,
모든 기능이 합ㅊ쳐진 이후에 다시 배포할 수 있으므로 개발의 안정성이 매우 뛰어나게
되는 겁니다.;


# 통합 브랜치 :
배포가 가능한 수준의 브랜치로 일반적으로 마스터(Master) 브랜치를 의미 합니다.;

# 토픽 브랜치 : 
특정한 기능을 위해 만들어진 브랜치로 일반적으로 마스터(Master)브랜치 이외의
다른 브랜치를 의미합니다.;


# 브랜치 사용해보기
브랜치를 만들 때는 git branch 명령어를 이용합니다. 저는 develop이라는 이름의 브랜치를 만들어
보도록 하겠습니다. 이후에 특정한 브랜치로 전환하고자 할 때는 git checkout 명령어를 이용합니다.
체크아웃(checkout) 이후에는 HEAD가 해당 브랜치로 이동하게 됩니다.


# Git Branch가 몇개 있는지 확인 하는 명령어
=> git branch


# Git Branch 만들기
=> git branch Develop
=> git branch로 확인 하면 master branch와 Develop브랜치가 있는걸 확인 가능!


# 다른 브랜치를 접속하는 방법
=> git checkout "이동할 브랜치명"
=> ex) git checkout develop


# 다른 브랜치에서 추가된 내용 master 브랜치에 적용하기
현재 위치 : develop ( 새로운 기능 구현 )
이동 위치 : master  ( develop의 새로운 기능 구현을 merge 하기)
=> git checkout master
=> git merge develop

이렇게 하면 develop 브랜치에서 추가 기능 구현된 내용을 master 브랜치에 merge할수 있다.

merge 후 git push로 remoteRepository 또한 변경될 수 있게 해줘야 한다. ( 반드시 master브랜치로 )


# 브랜치 삭제하기 최종적으로 master에 기능을 전부 주었다면 develop 브랜치 삭제
=> git branch -d 삭제할 브랜치
=> ex) git branch -d develop             
=> Deleted branch develop (was e1d730d). // 정상적으로 삭제가 되었음
;



# 브랜치 변경 후 변경한 브랜치로 push 하는 명령어
=> git push --set-upstream origin master


# master branch로 합치는것
=> 현재의 브랜치 경로가 develop이라면 master브랜치로 이동 후
git merge develop이라고 해야한다.
그렇다면 develop의 소스코드가 master 브랜치로 병합이 된다.



