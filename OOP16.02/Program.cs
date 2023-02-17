using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Diagnostics;



//дана строка
//отсортировать слова в соответсвии с количеством гласных букв

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();


            //string test = "This wIll check over each node in the data and see if the rOwIndex is 0, when it is, it usEs the node object to sEt the selected attribute  The Belarusian People's Republic was the first attempt to create an independent Belarusian state under the name \"Belarus\". Despite significant efforts, the state ceased to exist, primarily because the territory was continually dominated by the German Imperial Army and the Imperial Russian Army in World War I, and then the Bolshevik Red Army. It existed from only 1918 to 1919 but created prerequisites for the formation of a Belarusian state. The choice of name was probably based on the fact that core members of the newly formed government were educated in tsarist universities, with corresponding emphasis on the ideology of West-Russianism.[66] The Republic of Central Lithuania was a short-lived political entity, which was the last attempt to restore Lithuania in the historical confederacy state (it was also supposed to create Lithuania Upper and Lithuania Lower). The republic was created in 1920 following the staged rebellion of soldiers of the 1st Lithuanian–Belarusian Division of the Polish Army under Lucjan Żeligowski. Centered on the historical capital of the Grand Duchy of Lithuania, Vilna (Lithuanian: Vilnius, Polish: Wilno), for 18 months the entity served as a buffer state between Poland, upon which it depended, and Lithuania, which claimed the area.[67] After a variety of delays, a disputed election took place on 8 January 1922, and the territory was annexed to Poland. Żeligowski later in his memoir which was published in London in 1943 condemned the annexation of the Republic by Poland, as well as the policy of closing Belarusian schools and general disregard of Marshal Józef Piłsudski's confederation plans by Polish ally.[68] Meeting in the Kurapaty woods, 1989, where between 1937 and 1941 from 30,000 to 250,000 people, including Belarusian intelligentsia members, were murdered by the NKVD during the Great Purge. In January 1919 a part of Belarus under Bolshevik Russian control was declared the Socialist Soviet Republic of Byelorussia (SSRB) for just two months, but then merged with the Lithuanian Soviet Socialist Republic (LSSR) to form the Socialist Soviet Republic of Lithuania and Belorussia (SSR LiB), which lost control of its territories by August.The Byelorussian Soviet Socialist Republic (BSSR) was created in July 1920.The contested lands were divided between Poland and the Soviet Union after the war ended in 1921, and the Byelorussian SSR became a founding member of the Union of Soviet Socialist Republics in 1922.[62][69] In the 1920s and 1930s, Soviet agricultural and economic policies, including collectivization and five-year plans for the national economy, led to famine and political repression.[70]The western part of modern Belarus remained part of the Second Polish Republic.[71][citation needed][72] After an early period of liberalization, tensions between increasingly nationalistic Polish government and various increasingly separatist ethnic minorities started to grow, and the Belarusian minority was no exception.[73][74] The polonization drive was inspired and influenced by the Polish National Democracy, led by Roman Dmowski, who advocated refusing Belarusians and Ukrainians the right for a free national development.[75] A Belarusian organization, the Belarusian Peasants' and Workers' Union, was banned in 1927, and opposition to Polish government was met with state repressions.[73][74] Nonetheless, compared to the (larger) Ukrainian minority, Belarusians were much less politically aware and active, and thus suffered fewer repressions than the Ukrainians.[73][74] In 1935, after the death of Piłsudski, a new wave of repressions was released upon the minorities, with many Orthodox churches and Belarusian schools being closed.[73][74] Use of the Belarusian language was discouraged.[76] Belarusian leadership was sent to Bereza Kartuska prison.[77] Belarus lies between latitudes 51° and 57° N, and longitudes 23° and 33° E. Its extension from north to south is 560 km (350 mi), from west to east is 650 km (400 mi).[121] It is landlocked, relatively flat, and contains large tracts of marshy land.[122] About 40% of Belarus is covered by forests.[123][124] The country lies within two ecoregions: Sarmatic mixed forests and Central European mixed forests.[125] Many streams and 11,000 lakes are found in Belarus.[122] Three major rivers run through the country: the Neman, the Pripyat, and the Dnieper. The Neman flows westward towards the Baltic sea and the Pripyat flows eastward to the Dnieper; the Dnieper flows southward towards the Black Sea.[126] Strusta Lake in the Vitebsk Region The highest point is Dzyarzhynskaya Hara (Dzyarzhynsk Hill) at 345 metres (1,132 ft), and the lowest point is on the Neman River at 90 m (295 ft).[122] The average elevation of Belarus is 160 m (525 ft) above sea level.[127] The climate features mild to cold winters, with January minimum temperatures ranging from −4 °C (24.8 °F) in southwest (Brest) to −8 °C (17.6 °F) in northeast (Vitebsk), and cool and moist summers with an average temperature of 18 °C (64.4 °F).[128] Belarus has an average annual rainfall of 550 to 700 mm (21.7 to 27.6 in).[128] The country is in the transitional zone between continental climates and maritime climates.[122]Natural resources include peat deposits, small quantities of oil and natural gas, granite, dolomite (limestone), marl, chalk, sand, gravel, and clay.[122] About 70% of the radiation from neighboring Ukraine's 1986 Chernobyl nuclear disaster entered Belarusian territory, and about a fifth of Belarusian land (principally farmland and forests in the southeastern regions) was affected by radiation fallout.[129] The United Nations and other agencies have aimed to reduce the level of radiation in affected areas, especially through the use of caesium binders and rapeseed cultivation, which are meant to decrease soil levels of caesium-137.[130][131 Belarus borders five countries: Latvia to the north, Lithuania to the northwest, Poland to the west, Russia to the north and the east, and Ukraine to the south. Treaties in 1995 and 1996 demarcated Belarus's borders with Latvia and Lithuania, and Belarus ratified a 1997 treaty establishing the Belarus-Ukraine border in 2009.[132] Belarus and Lithuania ratified final border demarcation documents in February 2007.[133]";
            string x = "";
            var test = Enumerable.Range(0, 50000).ToList();
            stopwatch.Start();
            //тест цикла for
           
            for (int i = 0; i < test.Count; i++)
            {
                test[i]++;
                test[i]++;
                test[i]++;
                test[i]++;
                x += test[i].ToString();
            }
            //Console.WriteLine(x);

            //Regex regex = new Regex(@"[^aeuoiyAEUIYO]");
            //var result = test.Split(' ').Select(x => (regex.Replace(x, "").Length, x)).ToList();
            //result.Sort((x, y) => x.Item1 - y.Item1);
            //Console.WriteLine(string.Join(' ', result.Select(x => x.Item2)));

            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();
            x = "";
            test = Enumerable.Range(0, 50000).ToList();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            //тест цикла for

            for (int i = 0; i < test.Count; i++)
            {
                var item = test[i];
                item++;
                item++;
                item++;
                item++;
                x += item.ToString();
            }
            //Console.WriteLine(x);

            //Regex regex = new Regex(@"[^aeuoiyAEUIYO]");
            //var result = test.Split(' ').Select(x => (regex.Replace(x, "").Length, x)).ToList();
            //result.Sort((x, y) => x.Item1 - y.Item1);
            //Console.WriteLine(string.Join(' ', result.Select(x => x.Item2)));

            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();



            //            stopwatch = new Stopwatch();
            //            stopwatch.Start();
            //            string y = "";
            //            int j = 0;
            //            while (j < 30000)
            //            {
            //                y += ".";
            //                j++;
            //            }
            //            //Console.WriteLine(y);
            //            //Regex regex1 = new Regex(@"[^aeuoiyAEUIYO]");
            //            //var result1 = test.Split(' ').ToList();
            //            //result1.Sort((x, y) => regex1.Replace(x, "").Length - regex1.Replace(y, "").Length);
            //            //Console.WriteLine(string.Join(' ', result1));

            //            stopwatch.Stop();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //            Console.WriteLine();
            //            Console.WriteLine();




            //            //---------------------------------------
            //            stopwatch = new Stopwatch();
            //            var test = Enumerable.Range(0, 30000);

            //            stopwatch.Start();

            //            string result = "";

            //            foreach (int item in test)
            //            {
            //                result += ".";
            //            }
            //            //Console.WriteLine(result);
            //            //var array = test.Split(" ").ToList();

            //            //List<(int, string)> values = new List<(int, string)> { };


            //            ////List<string> strings = new List<string> { "a", "e", "y", "u", "o", "i" };
            //            //for (int i = 0; i < array.Count; i++)
            //            //{
            //            //    int kolglasn = 0;
            //            //    foreach (char c in array[i].ToLower())
            //            //    {
            //            //        if (c == 'a' || c == 'e' || c == 'y' || c == 'u' || c == 'o' || c == 'i')
            //            //        { kolglasn++; }
            //            //    }
            //            //    values.Add((kolglasn, array[i]));

            //            //    //(1,this) (2,over)
            //            //}
            //            //values.Sort((x, y) => x.Item1 - y.Item1);
            //            //var selectCollection = values.Select(product => product.Item2);
            //            //Console.WriteLine(string.Join(' ', selectCollection));
            //            ////foreach (var item in selectCollection)
            //            ////{
            //            ////    Console.Write($"{item} ");
            //            ////}

            //            stopwatch.Stop();
            //            Console.WriteLine();
            //            Console.WriteLine();
            //            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            //            //foreach (var item in values)
            //            //{
            //            //    Console.WriteLine(item.ToString());
            //            //}
            //            //parts.Sort((Part x, Part y) =>
            //            //           x.PartName == null && y.PartName == null
            //            //               ? 0
            //            //               : x.PartName == null
            //            //                   ? -1
            //            //                   : y.PartName == null
            //            //                       ? 1
            //            //                       : x.PartName.CompareTo(y.PartName));

            //            //Console.WriteLine("\nAfter sort by name:");
            //            //parts.ForEach(Console.WriteLine);
        }
    }
}


////1. расплитить строку на массив
////2. сортировка слов
////3. вывод сообщений как в конечном итоге располагается 



