# 10주차 과제

### 1) 레트로 유니티 프로젝트

레트로의 닷지게임을 따라만들고 추가 기능을 구현하세요.

1. 플레이어의 베스트 스코어를 PlayerPrefs로 저장하고, 게임 종료시 Debug.Log로 베스트 스코어를 출력합니다. 점수는 Bullet Spawner에서 Bullet이 생성된 경우 1씩 추가됩니다.
1. 현재 각 Bullet Spawner오브젝트 마다 BulletSpawner 스크립트가 들어있고, 해당 스크립트에서 지정한 시간마다 Bullet을 생성하고 있습니다. Bullet Spawner오브젝트에서 BulletSpawner스크립트를 삭제하고, Level게임 오브젝트에 BulletSpawner스크립트를 넣은 후, BulletSpawner스크립트에서 Bullet Spawner오브젝트의 트랜스폼을 받아 해당 트랜스폼에서 Bullet을 생성하게 변경해주세요.

과제가 완료되면 프로젝트를 압축하여 클래스룸 과제공지를 통해 과제를 제출해주세요.
과제는 11월 13일 오후 6시까지 제출해주세요.