# Unity_FrameWork
자주 사용하는 디자인 패턴을 구현하고, 예제를 제작하는 프로젝트

## Singleton Pattern
예제 Scene 이름 : Observer N Singleton

폴더 Scrit > Singleton 에 Singleton.cs 와 MonoSingleton.cs 가 있습니다.
전자는 하이어라키뷰에 GameObject 가 없어도 Singleton 을 상속 받으면 인스턴스가 생성됩니다.

후자는 반드시 하이어라키 뷰에 GameObject 가 있어야 하고, MonoSinglton을 상속받은 클래스가 컴포넌트로 추가되어 있어야 합니다.

Observer N Singleton 씬에서 CubeManager오브젝트에 추가된 CubeMangaer 스크립트 컴포넌트가 MonoSinglton을 상속받은 클래스입니다.

## Observer Pattern
예제 Scene 이름 : Observer N Singleton

폴더 Scrit > Observer 에 Observer_Pattern.cs 가 있습니다.

옵저버 패턴은 Singleton 클래스를 상속받아 구현했습니다.

사용 방법은 큐브 매니저에 

<Image>

</Image>
