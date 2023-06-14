using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Atividade_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //Mês da compra 
            
                //Variáveis

                int mes;
            
            Console.WriteLine( " -- Olá, seja bem vindo ao Aerosul! --" );

            Console.Write( "\n" );

            Console.WriteLine( " Em qual dos meses disponíveis vocé gostaria de viajar ?" );

            Console.Write( "\n" );

            Console.WriteLine( " -- Meses disponíveis --" );

            Console.Write( "\n" );

            Console.WriteLine( " 08 - Agosto" );

            Console.WriteLine( " 09 - Setembro" );

            Console.WriteLine( " 10 - Outubro" );

            Console.Write( "\n" );

            Console.Write( " Digite um número referente ao mês em que gostaria de viajar: " );
            mes = int.Parse( Console.ReadLine() );

            Console.Clear();
            
            //Dia da compra
            
            if ( mes >= 08 && mes <= 10 )
            {

                    //Variáveis
                    int dia;
                    
                Console.WriteLine( " -- Os dias Disponíveis estão entre o dia 06 e 21 --" );

                Console.Write( "\n" );
                
                Console.Write( " Por favor informe a data que deseja viajar: " );
                dia = int.Parse( Console.ReadLine() );

                Console.Clear();

                //Periodo
                    
                if ( dia >= 06 )
                {

                    if( dia <= 21 )
                    {

                            //Variáveis

                            string periodo;
                            
                        Console.WriteLine( " Em qual período seria mais confortável para o(a) Sr.(a) viajar ?" );

                        Console.Write( "\n" );

                        Console.WriteLine( " -- Periodos disponíveis --" );

                        Console.Write( "\n" );

                        Console.WriteLine( " - Manhã" );

                        Console.WriteLine( " - Tarde" );

                        Console.WriteLine( " - Noite" );

                        Console.Write( "\n" );

                        Console.Write( " Digite sua opção aqui: " );
                        periodo = Console.ReadLine();                            
                        
                        Console.Clear();

                        //Nota fiscal    
                        
                        if ( periodo == "Manhã" )
                        {

                            //Variáveis   
                            
                                var data_at = DateTime.Now;
                                
                            Console.WriteLine( " -- Nota Fiscal --" );

                            Console.Write( "\n" );

                            Console.WriteLine( " Sua viagem ficou agendada para:" );

                            Console.Write( "\n" );

                            Console.WriteLine( $" - Data: {dia}/{mes} deste ano." );

                            Console.WriteLine( $" - Periodo: {periodo}" );
                            
                            Console.Write( "\n" );

                            Console.WriteLine( $" Essa nota foi emitida {data_at}" );

                            Console.ReadKey();

                            Console.Clear();

                            Main( null );

                        }

                        if( periodo == "Tarde" )
                        {

                            //Variáveis   

                            var data_at = DateTime.Now;

                            Console.WriteLine( " -- Nota Fiscal --" );

                            Console.Write( "\n" );

                            Console.WriteLine( " Sua viagem ficou agendada para:" );

                            Console.Write( "\n" );

                            Console.WriteLine( $" - Data: {dia}/{mes} deste ano." );

                            Console.WriteLine( $" - Periodo: {periodo}" );

                            Console.Write( "\n" );

                            Console.WriteLine( $" Essa nota foi emitida {data_at}" );

                            Console.ReadKey();

                            Console.Clear();

                            Main( null );

                        }

                        if( periodo == "Noite" )
                        {

                            //Variáveis   

                            var data_at = DateTime.Now;

                            Console.WriteLine( " -- Nota Fiscal --" );

                            Console.Write( "\n" );

                            Console.WriteLine( " Sua viagem ficou agendada para:" );

                            Console.Write( "\n" );

                            Console.WriteLine( $" - Data: {dia}/{mes} deste ano." );

                            Console.WriteLine( $" - Periodo: {periodo}" );

                            Console.Write( "\n" );

                            Console.WriteLine( $" Essa nota foi emitida {data_at}" );

                            Console.Write( "\n\n" );

                            Console.WriteLine( " -- COMPRA EFETUADA COM SUCESSO --" );

                            Console.ReadKey();

                            Console.Clear();

                            Main( null );

                        }

                        Console.WriteLine( " Periodo inválido, infelizmente você terá que começar o processo novamente" );
                        
                        Console.ReadKey();

                        Console.Clear();

                        Main( null );

                    }

                    Console.WriteLine( " -- Data inválida, infelizmente você terá que começar o processo novamente --" );

                    Console.ReadKey();

                    Console.Clear();

                    Main( null) ;

                }

                Console.WriteLine( " -- Data inválida, infelizmente você terá que começar o processo novamente --" );

                Console.ReadKey();

                Console.Clear();

                Main(null);

            }

            Console.WriteLine( " -- Mês inválido, infelizmente você terá que começar o processo novamente --" );

            Console.ReadKey();

            Console.Clear();

            Main( null );

        }
    }
}
