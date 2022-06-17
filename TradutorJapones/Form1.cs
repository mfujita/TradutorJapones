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
            txtEntradaJapones.Text = "しゃしん";
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

                    else if (todoTexto[i].ToUpper() == "SHA") { japones.Add("しゃ"); }
                    else if (todoTexto[i].ToUpper() == "SHO") { japones.Add("しょ"); }
                    else if (todoTexto[i].ToUpper() == "SHU") { japones.Add("しゅ"); }
                }

                txtSaidaJapones.Text = "";

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
                List<string> portugues = new List<string>();

                //TODO: Encontrar todas as pronúncias das contrações de 2 síbalas

                string todoTexto = txtEntradaJapones.Text.Replace("しゃ", "!").
                    Replace("しょ", "@").
                    Replace("しゅ", "#");

                for (int i = 0; i < todoTexto.Length; i++)
                {
                    if (todoTexto[i] == ' ') { portugues.Insert(i, " "); }
                    else if (todoTexto[i] == 'あ') { portugues.Insert(i, "A"); }
                    else if (todoTexto[i] == 'え') { portugues.Insert(i, "E"); }
                    else if (todoTexto[i] == 'い') { portugues.Insert(i, "I"); }
                    else if (todoTexto[i] == 'お') { portugues.Insert(i, "O"); }
                    else if (todoTexto[i] == 'う') { portugues.Insert(i, "U"); }

                    else if (todoTexto[i] == 'か') { portugues.Insert(i, "KA"); }
                    else if (todoTexto[i] == 'け') { portugues.Insert(i, "KE"); }
                    else if (todoTexto[i] == 'き') { portugues.Insert(i, "KI"); }
                    else if (todoTexto[i] == 'こ') { portugues.Insert(i, "KO"); }
                    else if (todoTexto[i] == 'く') { portugues.Insert(i, "KU"); }

                    else if (todoTexto[i] == 'さ') { portugues.Insert(i, "SA"); }
                    else if (todoTexto[i] == 'せ') { portugues.Insert(i, "SE"); }
                    else if (todoTexto[i] == 'し') { portugues.Insert(i, "SHI"); }
                    else if (todoTexto[i] == 'そ') { portugues.Insert(i, "SO"); }
                    else if (todoTexto[i] == 'す') { portugues.Insert(i, "SU"); }

                    else if (todoTexto[i] == 'た') { portugues.Insert(i, "TA"); }
                    else if (todoTexto[i] == 'て') { portugues.Insert(i, "TE"); }
                    else if (todoTexto[i] == 'ち') { portugues.Insert(i, "TI"); }
                    else if (todoTexto[i] == 'と') { portugues.Insert(i, "TO"); }
                    else if (todoTexto[i] == 'つ') { portugues.Insert(i, "TSU"); }

                    else if (todoTexto[i] == 'な') { portugues.Insert(i, "NA"); }
                    else if (todoTexto[i] == 'ね') { portugues.Insert(i, "NE"); }
                    else if (todoTexto[i] == 'に') { portugues.Insert(i, "NI"); }
                    else if (todoTexto[i] == 'の') { portugues.Insert(i, "NO"); }
                    else if (todoTexto[i] == 'ぬ') { portugues.Insert(i, "NU"); }

                    else if (todoTexto[i] == 'は') { portugues.Insert(i, "HA"); }
                    else if (todoTexto[i] == 'へ') { portugues.Insert(i, "HE"); }
                    else if (todoTexto[i] == 'ひ') { portugues.Insert(i, "HI"); }
                    else if (todoTexto[i] == 'ほ') { portugues.Insert(i, "HO"); }
                    else if (todoTexto[i] == 'ふ') { portugues.Insert(i, "FU"); }

                    else if (todoTexto[i] == 'ま') { portugues.Insert(i, "MA"); }
                    else if (todoTexto[i] == 'め') { portugues.Insert(i, "ME"); }
                    else if (todoTexto[i] == 'み') { portugues.Insert(i, "MI"); }
                    else if (todoTexto[i] == 'も') { portugues.Insert(i, "MO"); }
                    else if (todoTexto[i] == 'む') { portugues.Insert(i, "MU"); }

                    else if (todoTexto[i] == 'ら') { portugues.Insert(i, "RA"); }
                    else if (todoTexto[i] == 'れ') { portugues.Insert(i, "RE"); }
                    else if (todoTexto[i] == 'り') { portugues.Insert(i, "RI"); }
                    else if (todoTexto[i] == 'ろ') { portugues.Insert(i, "RO"); }
                    else if (todoTexto[i] == 'る') { portugues.Insert(i, "RU"); }

                    else if (todoTexto[i] == 'わ') { portugues.Insert(i, "WA"); }
                    else if (todoTexto[i] == 'を') { portugues.Insert(i, "WO"); }

                    else if (todoTexto[i] == 'ん') { portugues.Insert(i, "N"); }

                    else if (todoTexto[i] == 'が') { portugues.Insert(i, "GA"); }
                    else if (todoTexto[i] == 'げ') { portugues.Insert(i, "GE"); }
                    else if (todoTexto[i] == 'ぎ') { portugues.Insert(i, "GI"); }
                    else if (todoTexto[i] == 'ご') { portugues.Insert(i, "GO"); }
                    else if (todoTexto[i] == 'ぐ') { portugues.Insert(i, "GU"); }

                    else if (todoTexto[i] == 'ざ') { portugues.Insert(i, "ZA"); }
                    else if (todoTexto[i] == 'ぜ') { portugues.Insert(i, "ZE"); }
                    else if (todoTexto[i] == 'じ') { portugues.Insert(i, "ZI"); }
                    else if (todoTexto[i] == 'ぞ') { portugues.Insert(i, "ZO"); }
                    else if (todoTexto[i] == 'ず') { portugues.Insert(i, "ZU"); }

                    else if (todoTexto[i] == 'だ') { portugues.Insert(i, "DA"); }
                    else if (todoTexto[i] == 'で') { portugues.Insert(i, "DE"); }
                    else if (todoTexto[i] == 'ぢ') { portugues.Insert(i, "DI"); }
                    else if (todoTexto[i] == 'ど') { portugues.Insert(i, "DO"); }
                    else if (todoTexto[i] == 'づ') { portugues.Insert(i, "DU"); }

                    else if (todoTexto[i] == 'ば') { portugues.Insert(i, "BA"); }
                    else if (todoTexto[i] == 'べ') { portugues.Insert(i, "BE"); }
                    else if (todoTexto[i] == 'び') { portugues.Insert(i, "BI"); }
                    else if (todoTexto[i] == 'ぼ') { portugues.Insert(i, "BO"); }
                    else if (todoTexto[i] == 'ぶ') { portugues.Insert(i, "BU"); }

                    else if (todoTexto[i] == 'ぱ') { portugues.Insert(i, "PA"); }
                    else if (todoTexto[i] == 'ぺ') { portugues.Insert(i, "PE"); }
                    else if (todoTexto[i] == 'ぴ') { portugues.Insert(i, "PI"); }
                    else if (todoTexto[i] == 'ぽ') { portugues.Insert(i, "PO"); }
                    else if (todoTexto[i] == 'ぷ') { portugues.Insert(i, "PU"); }

                    else if (todoTexto[i] == '!') { portugues.Insert(i, "SHA"); }
                    else if (todoTexto[i] == '@') { portugues.Insert(i, "SHO"); }
                    else if (todoTexto[i] == '#') { portugues.Insert(i, "SHU"); }

                    //TODO Substituir todas os símbolos pelas respectivas sílabas
                }

                foreach (var item in portugues)
                {
                    txtSaidaPortugues.Text += item;
                }
            }
        }
    }
}