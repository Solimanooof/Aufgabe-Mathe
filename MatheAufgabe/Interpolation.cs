using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheAufgabe
{
    public class Interpolation
    {
        
        public string lagrange(double[]XWerten, double[]YWerten)
        {
        
            double[] result= new double[XWerten.Length];
            double[] add = new double[XWerten.Length ];
            List<double> list = new List<double>();
            double Xi_Xk;
            double dieAbsoluteNummeramEnde=0;
            double dieNummervonZahlerOhneX;                 //ده عشان حساب الرقم الاخير اللي لوحده 
            double dieZweiteXohneY;               // ده يامعلم عشان احسب الارقام اللي مع الاكس لوحدها قبل ما تضرب في الاكس والواي اللي بره
            double dieZweiteXMitY = 0;                // ده عشان اخد الرقم اللي الاكسات 
            double KoeffizeintvonHochstenGradvonX=0;
            double dieDritteXOhneY;
            double dieDritteXmitY=1;
            string stringvonZahler="";
            string stringvonNenner = "";
            string Ergebnis="";
            string letzteErgebnis = "";
            string XvonK;

            for (int i =0; i < XWerten.Length ; i++)
            {
                Xi_Xk = 1;
                dieNummervonZahlerOhneX = 1;
                dieZweiteXohneY = 0;
                dieDritteXOhneY= 0; 
                XvonK = XWerten[i].ToString();
                stringvonZahler = null;
                stringvonNenner = null;
                for (int k = 0; k < XWerten.Length; k++)
                {
                    if (k !=i )
                    {

                        if (k >= 3)
                        {
                            dieDritteXOhneY = ((XWerten[k]* -1) * dieZweiteXohneY)+dieNummervonZahlerOhneX;
                        }
                        //die Koeffezient von zweiten X vor dem Multiplizieren mit Y
                        dieZweiteXohneY -= XWerten[k];

                        // das ist für Nenner 
                        Xi_Xk *= (XWerten[i] - XWerten[k]);


                        // das sind hier der nächste Teil von Klammer also (X-k) hier ist k 
                        dieNummervonZahlerOhneX *= XWerten[k];

                        stringvonZahler += $"(X - {XWerten[k]})";
                        stringvonNenner += "("+ XvonK + $" - { XWerten[k]})";
                      
                    }
                    
                }
                KoeffizeintvonHochstenGradvonX += (YWerten[i] / Xi_Xk);

                // das ist die also Y durch Nenner also Xi_Xk, damit nachher in Klammern multiplizieren
                dieAbsoluteNummeramEnde += (YWerten[i]/Xi_Xk)*dieNummervonZahlerOhneX;


                dieZweiteXMitY += dieZweiteXohneY* (YWerten[i] / Xi_Xk);

                dieDritteXmitY +=dieDritteXOhneY* (YWerten[i] /Xi_Xk);

                Ergebnis = Ergebnis + $" + {YWerten[i]} * " + stringvonZahler +" / "+ stringvonNenner;
            }


            if (XWerten.Length <=3)
            {
                return $"{KoeffizeintvonHochstenGradvonX} X^{XWerten.Length-1} + {dieZweiteXMitY} X + {dieAbsoluteNummeramEnde} " +"\n" +"das sind die Basis von Lagrange "+"\n"+Ergebnis;
                
            }
            else
            {
                return $"{KoeffizeintvonHochstenGradvonX} X^{XWerten.Length - 1} + {dieZweiteXMitY} X^2 + {dieDritteXmitY} X + {dieAbsoluteNummeramEnde}";
            }
            

            
        }

    }
}
