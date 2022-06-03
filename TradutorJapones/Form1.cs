namespace TradutorJapones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPort2Jap_Click(object sender, EventArgs e)
        {
            if (txtEntradaPortugues.Text != "")
            {
                string[] todoTexto = txtEntradaPortugues.Text.Split(" ");
                List<string> japones = new List<string>();

                for (int i = 0; i < todoTexto.Length; i++)
                {
                    if (todoTexto[i] == "" && todoTexto[i+1] == "") { japones.Add(" "); }
                    else if (todoTexto[i].ToUpper() == "A") { japones.Add("あ"); }
                    else if (todoTexto[i].ToUpper() == "E") { japones.Add("え"); }
                    else if (todoTexto[i].ToUpper() == "I") { japones.Add("い"); }
                    else if (todoTexto[i].ToUpper() == "O") { japones.Add("お"); }
                    else if (todoTexto[i].ToUpper() == "U") { japones.Add("う"); }

                    else if (todoTexto[i].ToUpper() == "KA") { japones.Add("か"); }
                    else if (todoTexto[i].ToUpper() == "KE") { japones.Add("け"); }
                    else if (todoTexto[i].ToUpper() == "KI") { japones.Add("き"); }
                    else if (todoTexto[i].ToUpper() == "KO") { japones.Add("こ"); }
                    else if (todoTexto[i].ToUpper() == "KU") { japones.Add("く"); }

                    else if (todoTexto[i].ToUpper() == "SA") { japones.Add("さ"); }
                    else if (todoTexto[i].ToUpper() == "SE") { japones.Add("せ"); }
                    else if (todoTexto[i].ToUpper() == "SHI") { japones.Add("し"); }
                    else if (todoTexto[i].ToUpper() == "SO") { japones.Add("そ"); }
                    else if (todoTexto[i].ToUpper() == "SU") { japones.Add("す"); }

                    else if (todoTexto[i].ToUpper() == "TA") { japones.Add("た"); }
                    else if (todoTexto[i].ToUpper() == "TE") { japones.Add("て"); }
                    else if (todoTexto[i].ToUpper() == "TI") { japones.Add("ち"); }
                    else if (todoTexto[i].ToUpper() == "TO") { japones.Add("と"); }
                    else if (todoTexto[i].ToUpper() == "TSU") { japones.Add("つ"); }

                    else if (todoTexto[i].ToUpper() == "NA") { japones.Add("な"); }
                    else if (todoTexto[i].ToUpper() == "NE") { japones.Add("ね"); }
                    else if (todoTexto[i].ToUpper() == "NI") { japones.Add("に"); }
                    else if (todoTexto[i].ToUpper() == "NO") { japones.Add("の"); }
                    else if (todoTexto[i].ToUpper() == "NU") { japones.Add("ぬ"); }

                    else if (todoTexto[i].ToUpper() == "HA") { japones.Add("は"); }
                    else if (todoTexto[i].ToUpper() == "HE") { japones.Add("へ"); }
                    else if (todoTexto[i].ToUpper() == "HI") { japones.Add("ひ"); }
                    else if (todoTexto[i].ToUpper() == "HO") { japones.Add("ほ"); }
                    else if (todoTexto[i].ToUpper() == "FU") { japones.Add("ふ"); }

                    else if (todoTexto[i].ToUpper() == "MA") { japones.Add("ま"); }
                    else if (todoTexto[i].ToUpper() == "ME") { japones.Add("め"); }
                    else if (todoTexto[i].ToUpper() == "MI") { japones.Add("み"); }
                    else if (todoTexto[i].ToUpper() == "MO") { japones.Add("も"); }
                    else if (todoTexto[i].ToUpper() == "MU") { japones.Add("む"); }

                    else if (todoTexto[i].ToUpper() == "RA") { japones.Add("ら"); }
                    else if (todoTexto[i].ToUpper() == "RE") { japones.Add("れ"); }
                    else if (todoTexto[i].ToUpper() == "RI") { japones.Add("り"); }
                    else if (todoTexto[i].ToUpper() == "RO") { japones.Add("ろ"); }
                    else if (todoTexto[i].ToUpper() == "RU") { japones.Add("る"); }

                    else if (todoTexto[i].ToUpper() == "WA") { japones.Add("わ"); }
                    else if (todoTexto[i].ToUpper() == "WO") { japones.Add("を"); }

                    else if (todoTexto[i].ToUpper() == "N") { japones.Add("ん"); }

                    else if (todoTexto[i].ToUpper() == "GA") { japones.Add("が"); }
                    else if (todoTexto[i].ToUpper() == "GE") { japones.Add("げ"); }
                    else if (todoTexto[i].ToUpper() == "GI") { japones.Add("ぎ"); }
                    else if (todoTexto[i].ToUpper() == "GO") { japones.Add("ご"); }
                    else if (todoTexto[i].ToUpper() == "GU") { japones.Add("ぐ"); }

                    else if (todoTexto[i].ToUpper() == "ZA") { japones.Add("ざ"); }
                    else if (todoTexto[i].ToUpper() == "ZE") { japones.Add("ぜ"); }
                    else if (todoTexto[i].ToUpper() == "ZI") { japones.Add("じ"); }
                    else if (todoTexto[i].ToUpper() == "ZO") { japones.Add("ぞ"); }
                    else if (todoTexto[i].ToUpper() == "ZU") { japones.Add("ず"); }

                    else if (todoTexto[i].ToUpper() == "DA") { japones.Add("だ"); }
                    else if (todoTexto[i].ToUpper() == "DE") { japones.Add("で"); }
                    else if (todoTexto[i].ToUpper() == "DI") { japones.Add("ぢ"); }
                    else if (todoTexto[i].ToUpper() == "DO") { japones.Add("ど"); }
                    else if (todoTexto[i].ToUpper() == "DU") { japones.Add("づ"); }

                    else if (todoTexto[i].ToUpper() == "BA") { japones.Add("ば"); }
                    else if (todoTexto[i].ToUpper() == "BE") { japones.Add("べ"); }
                    else if (todoTexto[i].ToUpper() == "BI") { japones.Add("び"); }
                    else if (todoTexto[i].ToUpper() == "BO") { japones.Add("ぼ"); }
                    else if (todoTexto[i].ToUpper() == "BU") { japones.Add("ぶ"); }

                    else if (todoTexto[i].ToUpper() == "PA") { japones.Add("ぱ"); }
                    else if (todoTexto[i].ToUpper() == "PE") { japones.Add("ぺ"); }
                    else if (todoTexto[i].ToUpper() == "PI") { japones.Add("ぴ"); }
                    else if (todoTexto[i].ToUpper() == "PO") { japones.Add("ぽ"); }
                    else if (todoTexto[i].ToUpper() == "PU") { japones.Add("ぷ"); }

                    else if (todoTexto[i].ToUpper() == "JA") { japones.Add("じゃ"); }
                    else if (todoTexto[i].ToUpper() == "JO") { japones.Add("じょ"); }
                    else if (todoTexto[i].ToUpper() == "JU") { japones.Add("じゅ"); }
                }

                foreach (var item in japones)
                {
                    txtSaidaJapones.Text += item.ToString();
                }
            }
        }

        private void btnJap2Port_Click(object sender, EventArgs e)
        {
            if (txtEntradaJapones.Text != "")
            {
                char[] todoTexto = txtEntradaJapones.Text.ToCharArray();
                List<string> portugues = new List<string>();

                for (int i = 0; i < todoTexto.Length; i++)
                {
                    if (todoTexto[i] == ' ') { portugues.Add(" "); }

                    else if (todoTexto[i] == 'ゃ')
                    {
                        if (todoTexto[i-1] == 'じ')
                        {
                            portugues.Add("Ja");
                            i++;
                        }
                    }

                    else if (todoTexto[i] == 'ょ')
                    {
                        if (todoTexto[i - 1] == 'じ')
                        {
                            
                            i++;
                            portugues.Add("Jo");
                        }
                    }

                    else if (todoTexto[i] == 'ゅ')
                    {
                        if (todoTexto[i - 1] == 'じ')
                        {
                            portugues.Add("Ju");
                            i++;
                        }
                    }

                    else if (todoTexto[i] == 'あ') { portugues.Add("A"); }
                    else if (todoTexto[i] == 'え') { portugues.Add("E"); }
                    else if (todoTexto[i] == 'い') { portugues.Add("I"); }
                    else if (todoTexto[i] == 'お') { portugues.Add("O"); }
                    else if (todoTexto[i] == 'う') { portugues.Add("U"); }

                    else if (todoTexto[i] == 'か') { portugues.Add("KA"); }
                    else if (todoTexto[i] == 'け') { portugues.Add("KE"); }
                    else if (todoTexto[i] == 'き') { portugues.Add("KI"); }
                    else if (todoTexto[i] == 'こ') { portugues.Add("KO"); }
                    else if (todoTexto[i] == 'く') { portugues.Add("KU"); }

                    else if (todoTexto[i] == 'さ') { portugues.Add("SA"); }
                    else if (todoTexto[i] == 'せ') { portugues.Add("SE"); }
                    else if (todoTexto[i] == 'し') { portugues.Add("SHI"); }
                    else if (todoTexto[i] == 'そ') { portugues.Add("SO"); }
                    else if (todoTexto[i] == 'す') { portugues.Add("SU"); }

                    else if (todoTexto[i] == 'た') { portugues.Add("TA"); }
                    else if (todoTexto[i] == 'て') { portugues.Add("TE"); }
                    else if (todoTexto[i] == 'ち') { portugues.Add("TI"); }
                    else if (todoTexto[i] == 'と') { portugues.Add("TO"); }
                    else if (todoTexto[i] == 'つ') { portugues.Add("TSU"); }

                    else if (todoTexto[i] == 'な') { portugues.Add("NA"); }
                    else if (todoTexto[i] == 'ね') { portugues.Add("NE"); }
                    else if (todoTexto[i] == 'に') { portugues.Add("NI"); }
                    else if (todoTexto[i] == 'の') { portugues.Add("NO"); }
                    else if (todoTexto[i] == 'ぬ') { portugues.Add("NU"); }

                    else if (todoTexto[i] == 'は') { portugues.Add("HA"); }
                    else if (todoTexto[i] == 'へ') { portugues.Add("HE"); }
                    else if (todoTexto[i] == 'ひ') { portugues.Add("HI"); }
                    else if (todoTexto[i] == 'ほ') { portugues.Add("HO"); }
                    else if (todoTexto[i] == 'ふ') { portugues.Add("FU"); }

                    else if (todoTexto[i] == 'ま') { portugues.Add("MA"); }
                    else if (todoTexto[i] == 'め') { portugues.Add("ME"); }
                    else if (todoTexto[i] == 'み') { portugues.Add("MI"); }
                    else if (todoTexto[i] == 'も') { portugues.Add("MO"); }
                    else if (todoTexto[i] == 'む') { portugues.Add("MU"); }

                    else if (todoTexto[i] == 'ら') { portugues.Add("RA"); }
                    else if (todoTexto[i] == 'れ') { portugues.Add("RE"); }
                    else if (todoTexto[i] == 'り') { portugues.Add("RI"); }
                    else if (todoTexto[i] == 'ろ') { portugues.Add("RO"); }
                    else if (todoTexto[i] == 'る') { portugues.Add("RU"); }

                    else if (todoTexto[i] == 'わ') { portugues.Add("WA"); }
                    else if (todoTexto[i] == 'を') { portugues.Add("WO"); }

                    else if (todoTexto[i] == 'ん') { portugues.Add("N"); }

                    else if (todoTexto[i] == 'が') { portugues.Add("GA"); }
                    else if (todoTexto[i] == 'げ') { portugues.Add("GE"); }
                    else if (todoTexto[i] == 'ぎ') { portugues.Add("GI"); }
                    else if (todoTexto[i] == 'ご') { portugues.Add("GO"); }
                    else if (todoTexto[i] == 'ぐ') { portugues.Add("GU"); }

                    else if (todoTexto[i] == 'ざ') { portugues.Add("ZA"); }
                    else if (todoTexto[i] == 'ぜ') { portugues.Add("ZE"); }
                    else if (todoTexto[i] == 'じ') { portugues.Add("ZI"); }
                    else if (todoTexto[i] == 'ぞ') { portugues.Add("ZO"); }
                    else if (todoTexto[i] == 'ず') { portugues.Add("ZU"); }

                    else if (todoTexto[i] == 'だ') { portugues.Add("DA"); }
                    else if (todoTexto[i] == 'で') { portugues.Add("DE"); }
                    else if (todoTexto[i] == 'ぢ') { portugues.Add("DI"); }
                    else if (todoTexto[i] == 'ど') { portugues.Add("DO"); }
                    else if (todoTexto[i] == 'づ') { portugues.Add("DU"); }

                    else if (todoTexto[i] == 'ば') { portugues.Add("BA"); }
                    else if (todoTexto[i] == 'べ') { portugues.Add("BE"); }
                    else if (todoTexto[i] == 'び') { portugues.Add("BI"); }
                    else if (todoTexto[i] == 'ぼ') { portugues.Add("BO"); }
                    else if (todoTexto[i] == 'ぶ') { portugues.Add("BU"); }

                    else if (todoTexto[i] == 'ぱ') { portugues.Add("PA"); }
                    else if (todoTexto[i] == 'ぺ') { portugues.Add("PE"); }
                    else if (todoTexto[i] == 'ぴ') { portugues.Add("PI"); }
                    else if (todoTexto[i] == 'ぽ') { portugues.Add("PO"); }
                    else if (todoTexto[i] == 'ぷ') { portugues.Add("PU"); }

                    
                    //else if (todoTexto[i] == 'じゃ') { portugues.Add("JA"); }
                    //else if (todoTexto[i] == 'じょ') { portugues.Add("JO"); }
                    //else if (todoTexto[i] == 'じゅ') { portugues.Add("JU"); }
                    }

                foreach (var item in portugues)
                {
                    txtSaidaPortugues.Text += item;
                }
            }
        }
    }
}