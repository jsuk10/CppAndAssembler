using System;

class Program
{
    static void Main()
    {
        string s = "ABCDEFGHIJ";

        // 1. new 사용
        Range r1 = new Range();
        Range r2 = new Range(2, ^2);    // 2~ 마지막2               "CDEFGH"

        // 2. 정적 메서드 사용
        Range r3 = Range.All;           // 전부 출력                "ABCDEFGHIJ"
        Range r4 = Range.StartAt(3);    // 3부터 전부               "DEFGHIJ"
        Range r5 = Range.EndAt(3);      // 처음부터 3까지           "ABC"

        // 3. 단축 표기법
        Range r6 = 2..7;                // 2~6                      "CDEFGH"
        Range r7 = 2..^2;               // 2~(end-3)                "CDEFGH"
        Range r8 = ..3;                 // 0~4 (Range.StartAt(3))   "DEFGHIJ"
        Range r9 = 3..;                 // 4~end (EndAt(3))         "ABC"
    }
}