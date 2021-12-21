# 목차

<br>

# Array

배열은 Ref Type

1.  배열의 선언

    Ref Type이기 때문에 new로 할당

    ```C#
    int[] arr;                                  //배열의 선언
    int[] arr2 = new int[5];                    //배열의 초기화
    int[] arr3 = new int[5] { 1, 2, 3, 4, 5 }   //개수 틀리면 error
    int[] arr4 = new int[] { 1, 2, 3, 4, 5 }    //초기값 있으면 크기 선언 안해도된다.
    int[] arr5 = { 1, 2, 3, 4, 5}               //이렇게도 가능
    ```

2.  배열의 타입

    `System.int32[]` -> ⭐`System.Array`⭐ -> `System.Object`

    ```C#
    Type t = arr5.GetType();
    Console.WriteLine(t.FullName);                  //배열의 타입 출력      (System.int32[])
    Console.WriteLine(t.BaseType.FullName);         //배열의 부모 타입 출력 (System.Array)
    Console.WriteLine(t.BaseType.BaseType.FullName);//최상위는 오브젝트.    (System.Object)
    ```

3.  다양한 함수 지원

    `System.Array` 으로부터 파상되어 다양한 메서드 지원

    1. Length

       해당 배열의 길이 반환

    2. GetLength(int)

       해당 index 2차원 배열의 길이 반환

    3. GetValue(int)

       int에 해당하는 값

    4. GetLowerBound(int)

       해당 index 2차원 배열의 최소 인덱스

    5. GetUpperBound(int)

       해당 index 2차원 배열의 최대 인덱스

    6. Clone()

       복사본을 생성, return 이 Object라서 캐스팅 해야함

    ```C#
    Console.WriteLine(arr5.Length);             // 5
    Console.WriteLine(arr5.GetLength(0));       // 5 (2차원 배열에서 0번째의 길이)
    Console.WriteLine(arr5.GetValue(3));        // 4 (arr5[3]의 값)
    Console.WriteLine(arr5.GetLowerBound(0));   // 0 (인덱스의 최소값)
    Console.WriteLine(arr5.GetUpperBound(0));   // 4 (인덱스의 최댓값)


    int[] arr6 = { 1, 2, 3, 4, 5 };         // 배열 생성
    int[] arr7 = arr6;                      // arr6을 가르킴
    // arr6의 복사본을 생성, return 이 Object라서 캐스팅 해야함
    int[] arr8 = (int[])arr6.Clone();
    Console.WriteLine(arr6 == arr7);   // true
    Console.WriteLine(arr6 == arr8);   // false
    ```

<br>

# 다차원 배열

2차원 배열

선언시 `int[,] arr`으로 하면된다.

```C#
int[] arr = new int[3];                             //선언

int[,] arr1 = new int[3, 2];                        //크기 선언
int[,] arr2 = new int[3, 2] { { 1, 1 },
                              { 2, 2 },
                              { 3, 3 } };           //선언과 동시에 초기화

int[,] arr3 = new int[,] { { 1, 1 },
                           { 2, 2 },
                           { 3, 3 } };              //초기화를 할 경우 크기 지정 안해도됨

int[,] arr4 = { { 1, 1 }, { 2, 2 }, { 3, 3 } };     //명시적으로도 된다.
```

해당 값을 할당 할 경우 `arr[0,0] = 10;`으로 가능하다.

foreach로 순차적으로 접근이 가능하다.

```C#
foreach (int n in arr2)
    Console.WriteLine(n);
```

다차원 배열

`int[,,] arr = new int[2,2,2];`로 , 수로 조절 할 수 있다.

<br>

# 가변 배열(Jagged Array)

다차원 배열에서 여러 크기를 가진 배열을 의미한다.

배열에서 다차원 배열은 배열 자체를 가지고 있는게 아니라 배열의 주소를 가지고 있다.

```C#
int[][] arr = new int[3][];

arr[0] = new int[3] { 1, 2, 3 };
arr[1] = new int[2] { 1, 2 };
arr[2] = new int[1] { 1 };
```

arr은 3개의 배열을 담을 수 있는 공간이 할당되었다.

이후 각각의 배열에 다른 크기의 배열을 넣었다 (Jagged Array)

```C#
int[][] arr2 = new int[3][] { new int[3],
                              new int[2],
                              new int[1] {0} }; //각각의 배열에 초기값도 줄 수 있음
```

이렇게도 가능.

> ⭐ 가변 배열(Jagged Array) => 배열을 가진 배열
