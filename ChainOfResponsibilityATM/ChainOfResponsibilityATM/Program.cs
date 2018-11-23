using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter FivePound = new FivePoundNoteSorter();
            Sorter TenPound = new TenPoundConcreteSorter();
            Sorter TwentyPound = new TwentyPoundConcreteSorter();
            Sorter FiftyPound = new FiftyPoundConcreteSorter();
            Sorter Coins = new CoinConcreteSorter();
            FivePound.SetSuccessor(TenPound);
            TenPound.SetSuccessor(TwentyPound);
            TwentyPound.SetSuccessor(FiftyPound);
            FiftyPound.SetSuccessor(Coins);

            for (int i = 0; i < 20; i++)
            {
                Client request = new Client(RandomGenerator.GenerateName(), RandomGenerator.GenerateInputMoney());
                FivePound.HandleRequest(request);
                Console.ReadKey();
            }
        } 
        
        abstract class Sorter
        {
            protected Sorter Successor;

            public void SetSuccessor(Sorter successor)
            {
                this.Successor = successor;
            }

            public abstract void HandleRequest(Client request);
        }

        class FivePoundNoteSorter : Sorter
        {
            public override void HandleRequest(Client request)
            {
                if (request.InputAmount == 5.00)
                {
                    Console.WriteLine(request.Name +" inserted "+ request.InputAmount + " into the ATM. " + this.GetType().Name + " Accepts this");
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(request);
                }
            }
        }
        
        class TenPoundNoteSorter : Sorter
        {
            public override void HandleRequest(Client request)
            {
                if (request.InputAmount == 10.00)
                {
                    Console.WriteLine(request.Name + " inserted " + request.InputAmount + " into the ATM. " + this.GetType().Name + " Accepts this");
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(request);
                }
            }
        }
        
        class TwentyPoundNoteSorter : Sorter
        {
            public override void HandleRequest(Client request)
            {
                if (request.InputAmount == 20.00)
                {
                    Console.WriteLine(request.Name + " inserted " + request.InputAmount + " into the ATM. " + this.GetType().Name + " Accepts this");
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(request);
                }
            }
        }
        
        class FiftyPoundNoteSorter : Sorter
        {
            public override void HandleRequest(Client request)
            {
                if (request.InputAmount == 50.00)
                {
                    Console.WriteLine(request.Name + " inserted " + request.InputAmount + " into the ATM. " + this.GetType().Name + " Accepts this");
                }
                else if (Successor != null)
                {
                    Successor.HandleRequest(request);
                }
            }
        }
        
        class CoinSorter : Sorter
        {
            public override void HandleRequest(Client request)
            {

                switch (request.InputAmount)
                {
                    case 0.01:
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 0.02:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 0.05:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 0.10:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 0.20:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 0.50:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 1.00:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;                                                                                                   
                    case 2.00:                                                                                                   
                        Console.WriteLine(request.Name + " tries to insert " + request.InputAmount + " into the ATM, the ATM rejects this");
                        break;

                }
            }
        }


    }
}
