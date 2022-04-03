public class Main {
    public static void Main(String args[]){
       //main fonksiyonunu bu sekilde kalabilir. Bu fonksiyon altina yazdiklariniz degerlendirmeye alinmayacaktir.
       System.out.println("Hello World");
    }
    
   public static double TersToplam(int m, int n) {
    if(m>n) {
      
      int temp =n;
      n = m;
      m = temp;
    }
    if(m<0 && n>-m) {
      
      m = -m +1;
    }
    double toplam = 0;
    for(double i=m;i<=n;i++) {
      if(i==0) continue;
      toplam += 1/i;
    }
    return toplam;
  }
 
    
    public static int AsalFark(int n)
    {
        if (n <= 2) return 0;

        int oncekiAsal = 0;
        int sonrakiAsal = 0;
        int kontrol = 0;
        int sayi = n;

       
          for (int i = sayi-1; i >1; i--)
          {
            for (int j = 2; j < sayi-1; j++)
            {
              if (i % j == 0) kontrol++;

            }
            if (kontrol == 0)
            {
                  oncekiAsal = i;
                  break;
            }
            kontrol = 0;
            sayi--;
            
          }
      sayi = n;
    
       for (int i = sayi+1; i >sayi; i++)
          {
            for (int j = 2; j < sayi+1; j++)
            {
              if (i % j == 0) kontrol++;

            }
            if (kontrol == 0)
            {
                  sonrakiAsal = i;
                  break;
            }
            kontrol = 0;
            sayi++;
            
          }
      int sonuc = sonrakiAsal-oncekiAsal;
      return sonuc; 
    }
    
    public static int ToplaPalindrome5(){
       return 0;
    }
    
    public static long ToplaPalindrome6(){
       return 0;
    }
    
    public static double PiKareBul(double m)
{
    double pi = 0;
    for (double i = 1; i <= m; i++)
    {
        pi += 1 / ((i * i * i) * ((i + 1) * (i + 1) * (i + 1)));
    }
    return 10.0 - pi;
}
  

    
    public static double EulerBul(int m)
{

    if(m<1 )
    {
      return 2.718;
    }
    double toplam = 1;
    for (double i = 1; i <= m; i++)
    {
        double payda = 1;
        for (double j = 1; j <= i; j++)
        {
            payda = payda * j;
        }
        toplam += 1 / payda;
    }
    return toplam;
}

    
   public static int KatalanSayisi(int n)
{    
    if(n==0)
      return 1;
    int katalanSayisi = 1;
    int basamak = 0;
    while (n-- > 1)
    {
        basamak++;
        katalanSayisi = katalanSayisi * ((4 * basamak) + 2) / (basamak + 2);
      
    }
    return katalanSayisi;
}

    
   public static int PerrinSayisi(int n)
        {
            if (n < 0) return -1;
            int[] sayilar = new int[n + 3];
            sayilar[0] = 3;
            sayilar[1] = 0;
            sayilar[2] = 2;
            for(int i = 0; i < n; i++)
            {
                sayilar[i + 3] = sayilar[i] + sayilar[i + 1];
               
            }
            return sayilar[n-1];
        }

    
   public static int CarpanToplam(int sayi)
{
    if (sayi < 0) return -1;
    var sonuc = 0;
    for (int i = 1; i <= sayi; i++)
    {
        if(sayi % i == 0)
        {
            sonuc += i;
        }
    }
    return sonuc;
}

    
public static int EkokBul(int m, int n)
{ 
    int max = m * n;
    int ekok = 0;  
    for (int i = max; i > 0; i--)
    {
        if (i % m == 0 && i % n == 0)
        {
            ekok = i;
        }
    }
    return ekok;
}
}
    

