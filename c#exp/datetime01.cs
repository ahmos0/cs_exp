using System;

class Datetime01
{
    public static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("今日は{0}年{1}月{2}日です", dt.Year, dt.Month, dt.Day, dt.DayOfWeek);
        Console.WriteLine("現在{0}時{1}分{2}秒{3}ミリセカンドです", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        Console.WriteLine("dt.Date = {0}", dt.Date);
        Console.WriteLine("短い日付形式 = {0}", dt.ToShortDateString());
    }
}