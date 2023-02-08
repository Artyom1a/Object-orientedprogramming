using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskExtencions.Enums;

namespace TaskExtencions.Extencions
{
    public static class FileExtencion
    {
        public static string FileTypeMessage(this FileTypes x)
        {
            if (Enum.IsDefined(x))
            {
                return $"Выбран файл с расширением *.{x}";
            }
         
            throw new Exception("Неверный формат файла");
        }

    }
}

//Написать метод
//расширения, который в зависимости от значения перечисления будет возвращать
//результат следующего вида: Выбран файл с расширением *. pdf”pdf”, если такого значения нет
//в перечислении бросать ошибку с сообщением Неверный формат файла
