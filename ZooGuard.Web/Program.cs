using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ZooGuard.Web
{
    public class Program
    {
    //����� Program - ��� �����, ��� ����������� �������������� ����������, ����� ��� HTTP-������, ���������� � IIS � ��������� ����������������
        public static void Main(string[] args)
        {
            CreateHostBuilder(args) //������� IHost �� IHostBuilder 
                .Build() //IHost - ���� ����������, ���������� ������������ ���������� � ������ Kestrel (����� ����������)
                .Run(); //��������� IHost � �������� ������������ ������� � ������������ ������ (����� ����������)
        }

        //���������� �������� ���������
        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args) //������� IHOSTBuilder ��������� ������������ �� ��������� (������������� ���� ��� ����� UI)
                .ConfigureWebHostDefaults(webBuilder => //����������� ���������� ��� ������������� Kestrel � ������������� HTTP-�������� (Web app)
                {
                    webBuilder.UseStartup<Startup>(); //����� Startup ���������� ������������ ������� (������ ������ ������������ ���������, �� ���� ����������� �������� �������� ��� �������)
                                                     
                });
    }
}
