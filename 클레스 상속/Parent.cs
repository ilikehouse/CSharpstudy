﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클레스_상속
{

    //용어 정리

    /*
     * 부모로 부터 상속 받았다
     * 
     * 상속을 받는 객체 vs 상속을 하는 개체
     *     자식(child)         부모(parent)
     *        down                  up
     *    파생된(Derived)        기반(base)
     *     extend                   super
     */

    /*
     * 접근 지정자 
     * private,public, protected
     * private : 자신 클래스 이외에는 모두 접근을 허용하지 않는다
     * public : 누구나 사용 가능하다
     * protected : 기본적으론 private 같은데, 자식 클래스에게만 public 허용을 해준다.
     */
    internal class Parent
    {
        private  int num1; //자식이 상속받지 않기를 원하는 내용
        public int num2;
        protected int num3;

        public Parent( int num2, int num3)
        {   
            this.num2 = num2;
            this.num3 = num3;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"num1 의 값 : {num1}");
        }
    }

    class Child : Parent    
    {

        public Child(int n2, int n3) : base(n2,n3)
        {

        }
        public override void ShowInfo()
        {
            base.ShowInfo();    
            Console.WriteLine($"num2 의 값:{num2}, num3 의 값:{num3}");
        }
    }
}
