
// Ref "/blob/master/app/src/main/java/com/nyasama/util/Discuz.java"
// So love OFz (die
// by Tung Leen, 4/1/16.
// Edited : 2016/6/13
// Edited : 2016/6/14


namespace Nyasama.Models
{
    public partial class Forum { }

    public class ForumProperties {

        private static string ForumHost = @"http://bbs.nyasama.com";
        public static string ForumApiPath = ForumHost + @"api/mobile/index.php";
        public string ForumEncodingStandard = "gbk";

    }

    public class Board {

        // 这里的术语略有不同。官方和 OFz 的术语叫做 Forum，但是这里因为 Forum 的名称
        // 被用掉了所以只能这么叫。

        public int Id;

    }

    public class SubBoard : Board {

        // 汉化联盟应用了子版块，这里单独列出。
        // 主要为了应对嵌套的情况。

    }

    public class Post {

        // Discuz 术语为 “帖子”，实为一层楼？

    }

    public class Thread {

        // Discuz 对应为主题。

        public int Id;
        public string Title;

    }

    public class User {

        // 因为 Discuz!X 本身带有的 UCenter，搞得这里有点乱。

        public string Name;
        public int Id;

    }
}
