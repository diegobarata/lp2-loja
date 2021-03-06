using System;
using System.Collections.Generic;

public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
    public string Desc;
}



public class Player
{
    public string nome;
    public int xp;
    public int gold;
    public List<Item> Itens = new List<Item>();
}



public class LP2_Trabalho
{

 
 
    static List<Player> Players = new List<Player>();

    public static void Main(string[] args)
    {
       
        
        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }

    }


    private static bool MenuPrincipal()
    {

            Item Espada_Vendaval = new Item();
            Espada_Vendaval.Id = 1;
            Espada_Vendaval.Nome = "Vendaval";
            Espada_Vendaval.Preco = 55;
            Espada_Vendaval.Desc = "(+30% VELOCIDADE DE ATAQUE)";

            Item Adagas_Navori = new Item();
            Adagas_Navori.Id = 2;
            Adagas_Navori.Nome = "Adagas Navori";
            Adagas_Navori.Preco = 100;
            Adagas_Navori.Desc = "(+10% DANO DE ATAQUE)";

            Item Espada_Do_Rei_Destruído = new Item();
            Espada_Do_Rei_Destruído.Id = 3;
            Espada_Do_Rei_Destruído.Nome = "Espada Do Rei Destruído";
            Espada_Do_Rei_Destruído.Preco = 20;
            Espada_Do_Rei_Destruído.Desc = "(CAUSA +15% DO DANO EQUIVALENTE A VIDA MÁXIMA RESTANTE DO ALVO)";

            Item Arco_Escudo_Imoral = new Item();
            Arco_Escudo_Imoral.Id = 4;
            Arco_Escudo_Imoral.Nome = "Arco Escudo Imoral";
            Arco_Escudo_Imoral.Preco = 90;
            Arco_Escudo_Imoral.Desc = "(+20% CHANCE DE ACERTO CRÍTICO)";

            Item Gume_Do_Infinito = new Item();
            Gume_Do_Infinito.Id = 5;
            Gume_Do_Infinito.Nome = "Gume do infiníto";
            Gume_Do_Infinito.Preco = 75;
            Gume_Do_Infinito.Desc = "(+40% DANO DE ACERTO CRÍTICO)";


       


        Console.Clear();
        Console.WriteLine("==================================================================");
        Console.WriteLine("Entre com '1' para criar um jogador (necessário para entrar na loja).");
        Console.WriteLine("Entre com '2' para checar as informações de todos os jogadores criados.");
        Console.WriteLine("Entre com '3' para olhar o seu inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");
        Console.WriteLine("==================================================================");
        switch (Console.ReadLine())
        {




            case "1":

                Console.Clear();  
                
                Console.Write("Insira um Nickname : ");
                var PlayerName = Console.ReadLine();
                PlayerName = PlayerName.ToLower();


                Console.Write("Insira uma quantidade de experiência: ");
                var PlayerExperience = Console.ReadLine();
               
                Random GetEXP = new Random();
                var PlayerCoins = GetEXP.Next(50, 350);


                Players.Add(new Player { nome = PlayerName, xp = Convert.ToInt32(PlayerExperience), gold = PlayerCoins});
                Console.Clear();
                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Adicionamos $" + PlayerCoins  + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();
            return true;


            case "2":
                Console.Clear();
                for (int i = 0; i < Players.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Nickname : " + Players[i].nome);
                    Console.WriteLine("Experiência : " + Players[i].xp);
                    Console.WriteLine("Ouro : " + Players[i].gold);                 
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            return true;
            



            case "3":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador para verificar o iventário:");
            var PlayerName0 = Console.ReadLine();
            PlayerName0 = PlayerName0.ToLower();
            foreach(Player p in Players)
            {
                if(p.nome == PlayerName0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }//END FOR
                    Console.WriteLine("");
                    Console.WriteLine("Entre com qualquer tecla para continuar");
                    Console.Read();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                    Console.Read();
                }
            }
            return true;//END CASE (SWITCH)









            case "4":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
            PlayerName0 = Console.ReadLine();
            PlayerName0 = PlayerName0.ToLower();
            foreach(Player p in Players)
            {
                if(p.nome == PlayerName0)
                {       
                    Console.WriteLine("- Insira o ID do item que você espera comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Espada_Vendaval.Id + " - " + Espada_Vendaval.Nome  + " " + Espada_Vendaval.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Adagas_Navori.Id + " - " + Adagas_Navori.Nome  + " " + Adagas_Navori.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Espada_Do_Rei_Destruído.Id + " - " + Espada_Do_Rei_Destruído.Nome  + " " + Espada_Do_Rei_Destruído.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Arco_Escudo_Imoral.Id + " - " + Arco_Escudo_Imoral.Nome  + " " + Arco_Escudo_Imoral.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Gume_Do_Infinito.Id + " - " + Gume_Do_Infinito.Nome + " " + Gume_Do_Infinito.Desc);       
                    Console.WriteLine("");
                    var ic = Console.ReadLine();
                 
                 



                    if( ic == Espada_Vendaval.Id.ToString() ){

                        Console.WriteLine("Você gostaria de comprar " + Espada_Vendaval.Nome + " por " + Espada_Vendaval.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_Vendaval.Preco)
                            {
                                p.gold = p.gold - Espada_Vendaval.Preco;
                                p.Itens.Add(Espada_Vendaval);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                               Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                    }





                    else if(ic == Adagas_Navori.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Adagas_Navori.Nome + " por " + Adagas_Navori.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);              
                         var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Adagas_Navori.Preco)
                            {
                                p.gold = p.gold - Adagas_Navori.Preco;
                                p.Itens.Add(Adagas_Navori);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                              else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }
                    }





                    else if(ic == Espada_Do_Rei_Destruído.Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Espada_Do_Rei_Destruído.Nome + " por " + Espada_Do_Rei_Destruído.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                       resp = resp.ToLower();
                        if(resp == "s" )
                        {
                            if(p.gold >= Espada_Do_Rei_Destruído.Preco)
                            {
                                p.gold = p.gold - Espada_Do_Rei_Destruído.Preco;
                                p.Itens.Add(Espada_Do_Rei_Destruído);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }
                         else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//END ELSE 
                    }





                    else if(ic == Arco_Escudo_Imoral.Id.ToString())
                    {
                       Console.WriteLine("Você gostaria de comprar " + Arco_Escudo_Imoral.Nome + " por " + Arco_Escudo_Imoral.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Arco_Escudo_Imoral.Preco)
                            {
                                p.gold = p.gold - Arco_Escudo_Imoral.Preco;
                                p.Itens.Add(Arco_Escudo_Imoral);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                           else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }
                             else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }
                    }





                     else if(ic == Gume_Do_Infinito.Id.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Gume_Do_Infinito.Nome + " por " + Gume_Do_Infinito.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Gume_Do_Infinito.Preco)
                            {
                                p.gold = p.gold - Gume_Do_Infinito.Preco;
                                p.Itens.Add(Gume_Do_Infinito);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");    
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {

                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }
                    }






                    else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                    }//END ELSE

                   





                 }
            }
             return true;//END CASE (SWITCH)


            
            case "5":
                return false;





            default:
                return true;





        }
    
    }






}
