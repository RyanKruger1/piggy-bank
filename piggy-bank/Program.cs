// See https://aka.ms/new-console-template for more information

using piggy_bank;
using piggy_bank.Enums;
using piggy_bank.Interfaces;

Boolean run_progam = true;
CommandLineClient client = new CommandLineClient();
PiggyBank bank = new PiggyBank();

List<string> coinsName = CoinMetaData.getCoinInformation().Keys.ToList();

client.greet();
while (run_progam)
{
    client.showAmount(bank.GetTotalAmount());
   
    switch (client.showMenu())
    {
        case 1:

            int selection = client.AskCoin(coinsName);

            Coin coin = new Coin(coinsName[selection - 1]);

            int amountCoins = client.getAmountCoins();

            for (int i = 0; i < amountCoins ;i++)
            {
                if ( PiggyBankMetaData.PiggyBank.maxVolumeCMM - bank.totalVolume > 0)
                {
                    bank.AddCoin(coin);
                }
                else
                {
                    Console.WriteLine("Your piggy bank is full, you cannot add any more coins");
                    break;
                }
            }

            break; 
        case 2:

            client.outputVolumes(PiggyBankMetaData.PiggyBank.maxVolumeCMM, bank.totalVolume);

            break;
        case 3:
            bank.Reset();
            break;
        case 4:
            // code block
            break;
    }

}
