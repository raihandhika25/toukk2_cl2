Console.Write("Masukan Nama :");
string nama = Console.ReadLine();
Console.Write("Masukan Nilai Harian :");
int nilaiharian = Convert.ToInt32(Console.ReadLine());
Console.Write("Masukan Nilai UTS :");
int nilaiuts = Convert.ToInt32(Console.ReadLine());
Console.Write("Masukan Nilai UAS :");
int nilaiuas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("===========================================");

Console.WriteLine("Nama : " + nama);
Console.WriteLine("Nilai Harian :" + nilaiharian);
Console.WriteLine("Nilai UTS : " + nilaiuts);
Console.WriteLine("Nilai UAS : " + nilaiuas);

int rata = (nilaiharian + nilaiuts + nilaiuas)/3;

if(rata >= 80){
    Console.WriteLine("Nilai Rata Rata Anda : " + rata);
    Console.WriteLine("Peringkat Anda A");
}
else if(rata >= 70){
    Console.WriteLine("Nilai Rata Rata Anda : " + rata);
    Console.WriteLine("Peringkat Anda B");
}
else if(rata >= 60){
    Console.WriteLine("Nilai Rata Rata Anda : " + rata);
    Console.WriteLine("Peringkat Anda C");
}
else if(rata >= 50){
    Console.WriteLine("Nilai Rata Rata Anda : " + rata);
    Console.WriteLine("Peringkat Anda D");
}
else
{
    Console.WriteLine("Nilai Rata Rata Anda : " + rata);
    Console.WriteLine("Peringkat Anda E");
}