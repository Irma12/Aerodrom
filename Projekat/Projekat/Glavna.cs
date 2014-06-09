using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Projekat
{
    public partial class Glavna : Form
    {
        public List<TipAviona> tipoviAviona;
        public List<Let> letovi;
        public List<Prtljag> prtljag;
        public List<Putnik> putnici;

        public Glavna()
        {
            InitializeComponent();
            tipoviAviona = new List<TipAviona>();
            letovi = new List<Let>();
            prtljag = new List<Prtljag>();
            putnici = new List<Putnik>();
        }

        private void dodajLetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                if (polijetanjeBox.Value < DateTime.Now)
                {
                    errorProvider1.SetError(polijetanjeBox, "Greska");
                    trakaGreske.Text = "Datum već prošao.";
                }
                else if (polijetanjeBox.Value > slijetanjeBox.Value)
                {
                    errorProvider1.SetError(polijetanjeBox, "Greska");
                    trakaGreske.Text = "Nije moguće slijetanje prije polijetanja";
                }


                else if (destinacijaCombo.SelectedIndex >= 0 && tipAvionaBox.SelectedIndex >= 0 && gatebox.SelectedIndex >= 0 && comboBox1.SelectedIndex >=0 && comboBox2.SelectedIndex>= 0 && comboBox3.SelectedIndex>=0 && comboBox4.SelectedIndex>=0)
                {
                    DateTime d1 = new DateTime(polijetanjeBox.Value.Year, polijetanjeBox.Value.Month, polijetanjeBox.Value.Day, comboBox1.SelectedIndex, comboBox2.SelectedIndex, Convert.ToInt32("00"));
                    DateTime d2 = new DateTime(slijetanjeBox.Value.Year, slijetanjeBox.Value.Month, slijetanjeBox.Value.Day, comboBox4.SelectedIndex, comboBox3.SelectedIndex, Convert.ToInt32("00"));
                    errorProvider1.SetError(polijetanjeBox, "");
                    
                    trakaGreske.Text = "";

                    TipAviona T = tipoviAviona[tipAvionaBox.SelectedIndex];


                    Let let1 = new Let(brojLetaTextbox.Text, destinacijaCombo.Text,d1,d2, gatebox.Text, T, cijenanumericUpDown1.Value);
                    bool a = false;

                    for (int i = 0; i < T.BrojSjedista; i++)
                    {
                        let1.sjedista.Add(a);
                    }
                    
                    letovi.Add(let1);
                    dataGridView1.DataSource = letovi;

                
                    brojLetaTextbox.Text = "18AA86-" + letovi.Count() / 5 + letovi.Count();
                    MessageBox.Show("Let je unesen!");
                }

                else
                {
                    errorProvider1.SetError(polijetanjeBox, "Greska");
                    trakaGreske.Text = "Niste popunili sve combobox-ove.";
                }
            }
      

        private void button16_Click(object sender, EventArgs e)
        {
            int a = 1;
            foreach (TipAviona t in tipoviAviona)
            {
                if (tipBox.Text == t.ImeTipa)
                {
                    errorProvider1.SetError(tipBox, "Greska");
                    trakaGreske.Text = "Postoji već avion sa tim imenom!"; a = 2;
                }
            }

            if (a == 1)
            {
                trakaGreske.Text = ""; errorProvider1.SetError(tipBox,"");
                TipAviona t = new TipAviona(tipBox.Text, Convert.ToInt32(brojSjedistanumericUpDown.Value));
                tipoviAviona.Add(t);
                MessageBox.Show("Uspjesno ste dodali novi tip aviona.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Prtljag p = new Prtljag(barKodtextBox.Text, richTextBox11.Text);
            prtljag.Add(p);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        
    

        private void Glavna_Load(object sender, EventArgs e)
        {
           


            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<TipAviona>));
                XmlTextReader citac = new XmlTextReader("tipovi_aviona.xml");
                tipoviAviona = (List<TipAviona>)deserializer.Deserialize(citac);
                citac.Close();

                listBox1.Items.Clear();
                tipAvionaBox.Items.Clear();
                foreach (TipAviona t in tipoviAviona)
                {
                    tipAvionaBox.Items.Add(t);

                    listBox1.Items.Add(t);
                }
            }

            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Let>));
                XmlTextReader citac = new XmlTextReader("letovi.xml");
                letovi = (List<Let>)deserializer.Deserialize(citac);
                citac.Close();

                letovilistBox1.Items.Clear();
                foreach (Let l in letovi)
                    letovilistBox1.Items.Add(l);
            }

            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Putnik>));
                XmlTextReader citac = new XmlTextReader("putnici.xml");
                putnici = (List<Putnik>)deserializer.Deserialize(citac);
                citac.Close();


            }
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Prtljag>));
                XmlTextReader citac = new XmlTextReader("prtljag.xml");
                prtljag = (List<Prtljag>)deserializer.Deserialize(citac);
                citac.Close();

                prtljaglistBox1.Items.Clear();
                foreach (Prtljag p in prtljag)
                    prtljaglistBox1.Items.Add(p);

            }

            brojLetaTextbox.Text = "18AA86-" + letovi.Count() / 5 + letovi.Count();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (izgubljenRadio.Checked == false)
            {
                MessageBox.Show("Potrebno je da označite da je prtljag izgubljen da biste provjerili da li je u bazi!");
            }
            else if (barKodtextBox.Text == "")
            {
                errorProvider1.SetError(barKodtextBox, "Unesite kod");
                trakaGreske.Text = "Niste unijeli kod";
            }
            else
            {
                foreach (Prtljag p in prtljag)
                {
                    if (barKodtextBox.Text == p.Kod)
                    {
                        MessageBox.Show("Prtljag nađen. Napomena: " + p.NapomenaP);
                        prtljag.Remove(p);
                        trakaGreske.Text = "";
                        errorProvider1.SetError(barKodtextBox, "");
                    }
                }
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (nađenRadio.Checked == true)
            {
                Prtljag p = new Prtljag(barKodtextBox.Text, richTextBox11.Text);
                prtljag.Add(p);
            }
            else
            {
                MessageBox.Show("Potrebno je da označite da je prtljag pronađen od strane nekog putnika da biste ga unijeli u bazu!");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (pripadnostcheckBox2.Checked == true)
            {
                foreach (Putnik p in putnici)
                {
                    if (p.Pasos == pasostextBox12.Text && p.Licna == licnatextBox11.Text && p.Ime == imetextbox.Text && p.Prezime == prezimetextBox11.Text)
                    {
                        MessageBox.Show("Dokumenti validni!"); i++;
                        trakaGreske.Text = "";
                        errorProvider1.SetError(pripadnostcheckBox2, "");
                    }
                }

                if (i == 1)
                {
                    MessageBox.Show("Dokumenti nisu validni!");
                }
            }
            else
            {
                errorProvider1.SetError(pripadnostcheckBox2, "Greška");
                trakaGreske.Text = "Potvrdite pripadnost čekiranjem kvadratića!";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(pripadnostcheckBox2, "");
            trakaGreske.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //kupovina
            Putnik p = new Putnik(imetextBox8.Text, prezimetextBox7.Text, licnatextBox5.Text, pasostextBox6.Text);
            Let l = letovi[letovilistBox1.SelectedIndex];
            Karta k = new Karta( KartatextBox13.Text, p, "K");

            l.karte.Add(k);


            for (int i = 0; i < l.TipAv.BrojSjedista; i++)
            {
                if (l.sjedista[i] == false)
                {
                    l.sjedista[i] = true;
                    break;
                }
            }

            MessageBox.Show("Kupljeno.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Putnik p = new Putnik(imetextBox8.Text, prezimetextBox7.Text, licnatextBox5.Text, pasostextBox6.Text);
            Let l = letovi[letovilistBox1.SelectedIndex];
            Karta k = new Karta(KartatextBox13.Text, p, "R");

            l.karte.Add(k);

            MessageBox.Show("Rezervisano.");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //xml spasavanje
            {
                XmlSerializer x = new XmlSerializer(typeof(List<TipAviona>));
                StreamWriter writer = new StreamWriter("tipovi_aviona.xml");

                x.Serialize(writer, tipoviAviona);
                writer.Close();
            }

            {
                XmlSerializer x = new XmlSerializer(typeof(List<Let>));
                StreamWriter writer = new StreamWriter("letovi.xml");

                x.Serialize(writer, letovi);
                writer.Close();

                letovilistBox1.Items.Clear();
                foreach (Let l in letovi)
                    letovilistBox1.Items.Add(l);
            }

            {
                XmlSerializer x = new XmlSerializer(typeof(List<Prtljag>));
                StreamWriter writer = new StreamWriter("prtljag.xml");

                x.Serialize(writer, prtljag);
                writer.Close();
            }

            {
                XmlSerializer x = new XmlSerializer(typeof(List<Putnik>));
                StreamWriter writer = new StreamWriter("putnici.xml");

                x.Serialize(writer, putnici);
                writer.Close();
            }

            // deserijalizacija
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<TipAviona>));
                XmlTextReader citac = new XmlTextReader("tipovi_aviona.xml");
                tipoviAviona = (List<TipAviona>)deserializer.Deserialize(citac);
                citac.Close();

                listBox1.Items.Clear();
                tipAvionaBox.Items.Clear();
                foreach (TipAviona t in tipoviAviona)
                {
                    tipAvionaBox.Items.Add(t);

                    listBox1.Items.Add(t);
                }
            }

            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Let>));
                XmlTextReader citac = new XmlTextReader("letovi.xml");
                letovi = (List<Let>)deserializer.Deserialize(citac);
                citac.Close();


            }
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Putnik>));
                XmlTextReader citac = new XmlTextReader("putnici.xml");
                putnici = (List<Putnik>)deserializer.Deserialize(citac);
                citac.Close();


            }
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Prtljag>));
                XmlTextReader citac = new XmlTextReader("prtljag.xml");
                prtljag = (List<Prtljag>)deserializer.Deserialize(citac);
                citac.Close();

                prtljaglistBox1.Items.Clear();
                foreach (Prtljag p in prtljag)
                    prtljaglistBox1.Items.Add(p);
            }
        }

        private void tipAvionaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        static public void XmlDeserijalizacija(List<TipAviona> ta, string XmlDok)
        {

            XmlSerializer deserializer = new XmlSerializer(typeof(List<TipAviona>));

            //2. Kreiranje streama za pisanja 
            XmlTextReader citac = new XmlTextReader(XmlDok);

            //3.Poziva se Deserialize metoda da vrati stanje objekta 
            ta = (List<TipAviona>)deserializer.Deserialize(citac);

            citac.Close();//4. Zatvaranje streama/datoteke 

            

        }

        private void Let_Click(object sender, EventArgs e)
        {
            brojLetaTextbox.Text = "18AA86-" + letovi.Count() / 5 + letovi.Count();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // deserijalizacija
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<TipAviona>));
                XmlTextReader citac = new XmlTextReader("tipovi_aviona.xml");
                tipoviAviona = (List<TipAviona>)deserializer.Deserialize(citac);
                citac.Close();

                foreach (TipAviona t in tipoviAviona)
                    tipAvionaBox.Items.Add(t.ImeTipa + "-" + t.BrojSjedista);
            }

            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Let>));
                XmlTextReader citac = new XmlTextReader("letovi.xml");
                letovi = (List<Let>)deserializer.Deserialize(citac);
                citac.Close();

                
            }
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Putnik>));
                XmlTextReader citac = new XmlTextReader("putnici.xml");
                putnici = (List<Putnik>)deserializer.Deserialize(citac);
                citac.Close();

                
            }
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Prtljag>));
                XmlTextReader citac = new XmlTextReader("prtljag.xml");
                prtljag = (List<Prtljag>)deserializer.Deserialize(citac);
                citac.Close();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            trakaGreske.Text = "";
            errorProvider1.SetError(toolStrip1, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trakaGreske.Text = "";
            errorProvider1.SetError(toolStrip1, "");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            trakaGreske.Text = "";
            errorProvider1.SetError(toolStrip1, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            Let b = new Let();

            foreach (Let l in letovi)
            {
                if (LetchtextBox12.Text == l.BrojLeta)
                {
                    a = 2;
                    foreach (Karta k in b.karte)
                    {
                        if (KartachtextBox1.Text == k.BrojKarte)
                        {
                            a = 3;
                            textBox4.Text = k.BrojKarte;

                            if (checkBox1.Checked == true)
                            {
                                if (Convert.ToInt32(textBox2.Text) > 60)
                                {
                                    textBox3.Text = (Convert.ToInt32(textBox2.Text) - 60).ToString() + ",00 KM";
                                }
                                else
                                {
                                    textBox3.Text = "00,00 KM";
                                }
                                errorProvider1.SetError(LetchtextBox12, "");
                                errorProvider1.SetError(KartachtextBox1, "");
                                errorProvider1.SetError(checkBox1, "");
                                trakaGreske.Text = "";
                                MessageBox.Show("Podaci validni.Propusnica spremna za printanje.");
                            }

                            else
                            {
                                errorProvider1.SetError(checkBox1, "greska");
                                trakaGreske.Text = "Niste čekirali plaćanje.";
                            }
                        }
                    }
                }
            }

            if( a == 1)
            {
                errorProvider1.SetError(LetchtextBox12, "Greska");
                trakaGreske.Text = "Let ne postoji.";
            }
            else if (a == 2)
            {
                errorProvider1.SetError(KartachtextBox1, "Greska");
                trakaGreske.Text = "Karta ne postoji.";
            }


            
        }

        private void letovilistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Let l = letovi[letovilistBox1.SelectedIndex];

            LettextBox10.Text = l.BrojLeta.ToString();
            textBox9.Text = l.VrijemePolaska.ToString();
            textBox11.Text = l.Cijena.ToString()+",00 KM";
                     
            int a = -1;

            if (l.sjedista.Count == 0)
            {
                for(int i = 0; i < l.TipAv.BrojSjedista; i++)
                {
                    l.sjedista.Add(false);
                }
 
                a = 0;
                KartatextBox13.Text = l.BrojLeta.ToString() + "-" + a.ToString();
            }
            else
            {
                for (int i = 0; i < l.TipAv.BrojSjedista; i++)
                {
                    if (l.sjedista[i] == false)
                    {

                        a = i;
                        KartatextBox13.Text = l.BrojLeta.ToString() + "-" + i.ToString();
                        break;
                    }
                }
            }

                if (a == -1)
                {
                    trakaGreske.Text = "Nema više karata za prodaju";
                    KartatextBox13.Text = "---NO---";
                }
            


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < letovi.Count; i++)
                for (int j = 0; j < letovi[i].karte.Count; j++)
                {
                    if (letovi[i].BrojLeta == textBox6.Text && letovi[i].karte[j].BrojKarte == textBox5.Text)
                    {
                        a = 1;
                        MessageBox.Show("Pronađeno.");
                        if (letovi[i].karte[j].Status == "K")
                        {
                            textBox7.Text = "Kupljena";
                            textBox8.Text = letovi[i].Cijena.ToString() + ",00 KM";
                            textBox10.Text = Convert.ToString(Convert.ToUInt32(letovi[i].Cijena) * 0.7) + ",00 KM";
                        }
                        else
                        {
                            textBox7.Text = "Rezervisana";
                            textBox8.Text = "Nije plaćeno.";
                            textBox10.Text = "00,00 KM";
                        }

                        break;
                    }
                }

            if (a == 0) MessageBox.Show("Nije pronađeno");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < letovi.Count; i++)
                for (int j = 0; j < letovi[i].karte.Count; j++)
                {
                    if (letovi[i].BrojLeta == textBox6.Text && letovi[i].karte[j].BrojKarte == textBox5.Text)
                    {
                       
                        letovi[i].sjedista[i] = false;
                        letovi[i].karte.Remove(letovi[i].karte[j]);
                    }
                }

            MessageBox.Show("Potvrđeno");
        }

        private void toolStripButton4_Click(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Let;
        }

        

       
       
     

         
        


            
        
    }
}