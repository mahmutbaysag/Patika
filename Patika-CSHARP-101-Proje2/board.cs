using System;
using System.Collections;
using Microsoft.VisualBasic;

public class Board{
    
    public ArrayList Lines = new ArrayList();

    public Board(){
        CardBox ToDoLine = new CardBox("TODO");
        CardBox InProgressLine = new CardBox("IN PROGRESS");
        CardBox DoneLine = new CardBox("DONE");
        
        Lines.Add(ToDoLine);
        Lines.Add(InProgressLine);
        Lines.Add(DoneLine);

        this.CardEkle("kart 1","içerik 1",2,3,"TODO");
        this.CardEkle("kart 2","içerik 2",3,1,"IN PROGRESS");
        this.CardEkle("kart 3","içerik 3",4,2,"DONE");
    }

    public void CardEkle(string title,string content,int size,int userid,string line){
        Card card = new Card(title,content,size,userid);
        foreach(CardBox lin in Lines){
            if(lin.Name==line){
                lin.Add(card);
            }
        }
    }

    public void CardSil(string title){
        foreach(CardBox line in Lines){
            foreach(Card card in line.cards){
                if(card.Title == title){
                    line.Remove(card);
                }   
            }
        }
    }

    public void CardGuncelle(string title,Card c){
        foreach(CardBox line in Lines){
            foreach(Card card in line.cards){
                if(card.Title==title){
                    card.Guncelle(c.Content,c.Size,c.Userid);
                }
            }
        }
    }
    public void CardTasi(string title,string from, string to){
        foreach(CardBox lin in Lines){
            if(lin.Name==from){
                foreach(Card card in lin.cards){
                    if(card.Title==title){
                        foreach(CardBox t in Lines){
                            if(t.Name == to){
                                t.Add(card);
                                lin.Remove(card);
                            }
                        }
                    }
                }
            }
        }
    }

    enum sizes
    {
        XS,S,M,L,XL
    }
    
    public void Listele(){
        

        foreach(CardBox line in Lines){
            Console.WriteLine($"{line.Name} Line");
            Console.WriteLine("************************");
            int sayac=0;
            foreach(Card card in line.cards){
                Console.WriteLine($"Başlık      :{card.Title}");
                Console.WriteLine($"İçerik      :{card.Content}");
                Console.WriteLine($"Atanan Kişi :{card.Userid}");
                string siz ="";
                switch(card.Size){
                    case 1:{ siz=sizes.XS.ToString();}break;
                    case 2:{ siz=sizes.S.ToString();}break;
                    case 3:{ siz=sizes.M.ToString();}break;
                    case 4:{ siz=sizes.L.ToString();}break;
                    case 5:{ siz=sizes.XL.ToString();}break;
                }
                Console.WriteLine($"Büyüklük    :{siz}");
                Console.WriteLine($"Line        :{line.Name}");
                Console.WriteLine("-");
                sayac++;
            }
            if(sayac==0){
                Console.WriteLine("⁓ BOŞ ⁓");
            }
        }
    }

    public bool CardVarmi(string title){
        foreach(CardBox line in Lines){
            foreach(Card card in line.cards){
                if(card.Title==title){
                    return true;
                }
            }
        }
        return false;
    }

    public string CardLineBul(string title){
        foreach(CardBox line in Lines){
            foreach(Card card in line.cards){
                if(card.Title==title){
                    return line.Name;
                }
            }
        }
        return "";
    }
    
}


public class CardBox{
    
    public string Name;

    public CardBox(string name){
        this.Name = name;
    }
    public ArrayList cards = new ArrayList();

    public void Add(Card card){
        this.cards.Add(card);
    }

    public void Remove(Card card){
        this.cards.Remove(card);
    }

    public void Update(string title,string content,int size, int userid){
        int sayac=0;
        foreach(Card card in this.cards){
            if(card.Title == title){
                Card tempCard = new Card(title,content,size,userid);
                this.cards[sayac]=tempCard;
            }
            sayac++;
        }
    }
}