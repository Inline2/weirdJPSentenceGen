using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace sentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int parse;
            var rng = new Random();
            List<string> write = new List<string>();
            //The program draws words from these arrays so you can add more to get more combinations if you want
            string[] nouns = {"くるま","本","あなた","ペン","これ","それ","子供","だん性","女性","かぞく","まち","いなか","せかい","いえ","みち","お店","ドア","テーブル","いす","まど","しんぶん","バッグ","しあわせ","あい","花","ボール","しごと","きゅうか","パスポート","げんご","しつもん","こたえ"};
            string[] adjectives = {"よい","すごい","かっこいい","ただしい","やさしい","うれしい","かんたん","げんき","たのしい","すばらしい","わるい","ひどい","ダサい","間違った","むずかしい","しつれい","かなしい","めんどい","つまらない","いや","大きい","小さい","たかい","ひくい","ふとい","おもい","かるい","あかい","オレンジ","きいろい","みどり","あおい","むらさき","ピンク","くろい","しろい","はいいろ","ちゃいろ","ながい","みじかい","ふかい","はやい","おそい","おいしい","まずい","あつい","さむい","しんせん","くさった","あかるい","くらい","きたない","やわらかい","かたい","つよい","よわい","あぶない","ぬれた","そうぞうしい","いそがしい","かわいい","こわい","するどい"};
            Console.WriteLine("Type how many phrases you want to generate.");
            var input = Console.ReadLine();
            Int32.TryParse(input, out parse);
            if(parse!=0)
            {
                for(var i = 0; i < parse; i++)
                {
                    write.Add($"{nouns[rng.Next(nouns.Length)]}は{adjectives[rng.Next(adjectives.Length)]}です"); //forms generic noun is adjective sentences
                }
            }
            else
            {
                Console.WriteLine("Input failed, try again.");
            }
            File.WriteAllLines(@"sentenceGenerator.txt", write);
        }
    }
}
