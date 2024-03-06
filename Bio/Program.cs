/* Blev 4 rewrites vara sista från scratch. Mycket av detta är kasserat och ligger nödvändigtvis inte kvar eller oigenkännligt.
 * Därför kan vissa delar ABSOLUT vara varken de snabbaste eller mest effektiva och vissa absolut inkonsekventa (tex. vara/icke vara i StandardMessages).
 * Jag lär mig bäst genom att leka runt, tvinga mig att lära mig saker som tycker hade varit häftingt att använda som inte alls behövs för att göra uppgiften etc.
 * Stringhantering, overrides, enums, regEx., Dictionary, mycket Debug-träningm validering är bara några saker jag kikat på väldigt mycket. 
 * 
 * Static med flera klasser vara lite otydligt för mig med scopet om hur & var de skulle initieras. I kombinationtion med ideliga nya ideér är inte nödvändigtvis bra ;-)
 * samt att jag byggde med fel tänk gällande priotering (även om jag var ganska medveten om detta).
 * 
 * Alla uppgifter inklusive extra uppgifterna skall vara gjorda.
 * Slopade Helper files, XML, i denna sista version, kommentarer är sparsamt.
 * Men världens bästa asci finns efter program avslut.
 * Upptäckte även en bug i koden i prisehanteringen för Enkel biljett-köp med, får fixa senare.
 * 
 * Viktigaste jag tog med mig från uppgiften framöver: 
 * 1. Planera flödet i detalj innan något annat
 * 2. Bygg absolut bare minimum enligt planeringen
 * 3. Först efter det putsa, implementera KISS, Single responsibility principle etc.
 * 
 * Jens
 */


namespace Bio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu();

            static void MainMenu()
            {
                char menuInput = '\0';
                do
                {
                    StandardMessages.MenuMessage();
                    if (char.TryParse(Console.ReadLine()!.ToUpper(), out menuInput))
                    {
                        switch (menuInput)
                        {
                            case '1':
                                TicketSubMenu();
                                break;
                            case '2':
                                RepeatPhrase.RepeatUserPhrase();
                                Console.ReadLine();
                                break;
                            case '3':
                                StringSplit.SplitTheString();
                                Console.ReadLine();
                                break;
                            case 'H':
                                StandardMessages.MenuHelpMessage();
                                break;
                            case '0':
                                StandardMessages.QuitProgram();
                                break;
                            default:
                                StandardMessages.ErroneousInputMessage();
                                break;
                        }
                    }
                } while (menuInput != '0');
            }
            static void TicketSubMenu()
            {

                char menuInput = '\0';
                do
                {
                    StandardMessages.TicketSubMenuMessage();
                    if (char.TryParse(Console.ReadLine()!.ToUpper(), out menuInput))
                    {
                        switch (menuInput)
                        {
                            case '1':
                                Utilities.AddOneTicket();
                                break;
                            case '2':
                                Utilities.GetNumberOfTickets();
                                break;
                            case '3':
                                StandardMessages.ToPreviousMenu();
                                break;
                            case 'H':
                                StandardMessages.MenuHelpMessage();
                                break;
                            default:
                                StandardMessages.ErroneousInputMessage();
                                break;
                        }
                    }
                } while (menuInput != '3');
            }
        }
    }
}





