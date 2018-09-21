 
 
 public void getSessionID()
           {
               string URL = "https://24401.tagpay.fr/online/online.php?";
               var request = WebRequest.Create(URL);
               var response = (HttpWebResponse)request.GetResponse();
               Stream data = response.GetResponseStream();

               
           }
 
 
 
 
 public  string getURL(string merchantid)
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            string webData = wc.DownloadString("https://24401.tagpay.fr/online/online.php?merchantid="+merchantid);

            return webData;
        }

      public  string getSessionIDS()
        {
            Program program = new Program();
            string mID = "2769989316156566";
            string url = program.getURL(mID);
            

            string left = url.Substring(0, 3);
            string right = url.Substring(3, 32);
            string nok = "Erro ao tentar aceder a página";

            if (left.Equals("OK:"))
                return right;
            else
            {
                return nok;
            }

            //   u can still retrieve with JS and store it on a variable... transfer that on a POST form
        }

