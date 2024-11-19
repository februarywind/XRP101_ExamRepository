# 4번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 1. Player
- 상태 패턴을 사용해 Idle 상태와 Attack 상태를 관리한다.
- Idle상태에서 Q를 누르면 Attack 상태로 진입한다
  - 진입 시 2초 이후 지정된 구형 범위 내에 있는 데미지를 입을 수 있는 적을 탐색해 데미지를 부여하고 Idle상태로 돌아온다
- 상태 머신 : 각 상태들을 관리하는 객체이며, 가장 첫번째로 입력받은 상태를 기본 상태로 설정한다.

### 2. NormalMonster
- 데미지를 입을 수 있는 몬스터

### 3. ShieldeMonster
- 데미지를 입지 않는 몬스터

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- ### 오류 해결
  - StateAttack의 Attack 함수에서 damagable = col.GetComponent<IDamagable>();에 대한 예외 처리가 없어 오류가 발생함 damagable가 null 일 때 continue 하도록 변경
  - StateAttack의 DelayRoutine에서 Exit을 직접 호출하여 상태 변경이 무한 반복됨 ChangeState을 사용하도록 변경함
- ### 코드 개선
  - StateAttack의 DelayRoutine에서 action이 사용되지 않으므로 제거함
