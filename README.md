# Unity_FrameWork
게임을 제작할 때 자주 사용하는 디자인 패턴을 구현하고, 예제를 제작하는 프로젝트

그외에 단일적으로 사용할 수 있는 코드를 업로드 (ex. DebugLogManager.cs)

## Singleton Pattern
예제 Scene 이름 : Observer N Singleton

폴더 Scrit > Singleton 에 Singleton.cs 와 MonoSingleton.cs 가 있습니다.
전자는 하이어라키뷰에 GameObject 가 없어도 Singleton 을 상속 받으면 인스턴스가 생성됩니다.

후자는 반드시 하이어라키 뷰에 GameObject 가 있어야 하고, MonoSinglton을 상속받은 클래스가 컴포넌트로 추가되어 있어야 합니다.

Observer N Singleton 씬에서 CubeManager오브젝트에 추가된 CubeMangaer 스크립트 컴포넌트가 MonoSinglton을 상속받은 클래스입니다.

## Observer Pattern (참고 링크 : https://github.com/KorStrix/Unity_Pattern.git)
예제 Scene 이름 : Observer N Singleton

폴더 Scrit > Observer 에 Observer_Pattern.cs 가 있습니다.

옵저버 패턴은 Singleton 클래스를 상속받아 구현했습니다.

사용 방법 : Observer_Pattern 변수를 선언하고, 해당 변수의 멤버에 있는 Subscribe 에 이벤트 함수를 등록합니다.
이벤트가 발생하는 시점에 DoNotify 를 호출해줍니다.

자세한 예시는, 큐브 매니저에 아래와 같이 적힌 변수가 있습니다. 해당 변수를 참조하는 곳을 보시면 어떻게 사용하는지 파악할 수 있을 겁니다.

![Example_Observer_Pattern](https://user-images.githubusercontent.com/17717157/101870501-131a0300-3bc5-11eb-8a03-aec3b8685336.png)

===================================================================================
## DegbugLogManager
특정 플랫폼에서는 디버그 모드를 체크하여 디버그 모드일 때만, 로그가 출력되도록 한다.

현재는 아래 그림과 같이 Android, IOS, 윈도우 실행 파일 일 경우에는 디버그 모드를 체크하도록 되어있습니다.
![image](https://user-images.githubusercontent.com/17717157/101871778-80c72e80-3bc7-11eb-8f89-4f0f4f92b767.png)

