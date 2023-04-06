
# git에서 로그를 본다는건 시간별로 commit을 한 내용을 보겠다는 의미

# 기록(log)에서 각 commit에 대한 통계정보를 내어주는 명령어
=> git log --stat
실제로 해당 파일에 얼마나 많은 라인이 추가되었는지 확인 가능

# graph는 브랜치와 병합정보를 graph로 출력해서 보기 좋게
=> git log --graph

# p같은 경우 : 커밋에 적용된 log의 구체적인 항목을 출력
=> git log -p

# log 기록들을 한줄로 깔끔하게 정렬해서 출력해주는 명령어
=> git log --pretty=oneline

# pretty 에서 특정 포맷을 정해주는 경우 명령어
=> git log --pretty=format:"%h -> %an, %ar : $s" --graph
# 그래프와 언제 커밋이 이루어 졌는지, 해시값이 얼마인지 등록자가 누구인지 시간이 얼마 전인지
# 커밋 메시지는 뭐라고 적었는지 확인 가능 명령어
*   a63a6ce -> GitWoogeun, 36 minutes ago : Add My_Module Add Command
|\
| * 0e21f3a -> GitWoogeun, 42 minutes ago : Add module[DIV]
* | 697f11a -> GitWoogeun, 41 minutes ago : Add Command
|/
* e1d730d -> GitWoogeun, 83 minutes ago : [Add my_module [MUL] 추가]
* c7845e0 -> GitWoogeun, 2 hours ago : [Add my_module.py [Add & Sub]]
* cd1e6dd -> GitWoogeun, 2 hours ago : [Add my_module [Add]
* 40083d1 -> GitWoogeun, 8 hours ago : Add Text File [document.txt]


