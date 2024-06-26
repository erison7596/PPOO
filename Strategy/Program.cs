﻿using Strategy.Filters;
using Strategy.Models;
using Strategy.Observers;

class Program
{
    static void Main(string[] args)
    {
        //provavelmente esta errado, mas eu estou enviando para tentar ganhar ao menos 1 ponto
        FileInfo inputTextFile = new FileInfo("../../../Hamlet.txt"); //ele meio que entra dentro da pasta debug, por isso tem tanto ../

        WebSearchModel model = new WebSearchModel(inputTextFile);

        model.AddQueryObserver(new FriendFilter(), new LambdaQueryObserver(query => Console.WriteLine($"Oh Yes! {query}")));
        model.AddQueryObserver(new LengthFilter(), new LambdaQueryObserver(query => Console.WriteLine($"So long.... {query}")));

        model.PretendToSearch();
    }
}