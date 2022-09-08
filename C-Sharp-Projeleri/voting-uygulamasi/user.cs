using System;
using System.Collections;

public class users{
    public ArrayList userlar = new ArrayList();

    public void Add(){
        Console.Write("Kullanıcı adı giriniz: ");
        string name = Console.ReadLine();
        Console.Write("Kullanıcı kimlik numarası giriniz: ");
        string identity = Console.ReadLine();
        userlar.Add(new user(identity,name));
    }

    public bool KullaniciVarmi(string username){
        foreach(user u in userlar){
            if(u.Name==username){
                return true;
            }
        }
        return false;
    }
}

public class user{
    private string identity;
    private string name;

    public string Identity{get; set;}
    public string Name{get; set;}

    public user(string identity,string name){
        this.Identity = identity;
        this.Name = name;
    }
}