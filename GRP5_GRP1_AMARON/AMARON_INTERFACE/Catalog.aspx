<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="AMARON_INTERFACE.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        body{
            background-color:aqua;
            min-width:290px;
            line-height: 1.5;
        }
        #navbar{
          position:fixed;
          min-width:290px;
          top:0px;
          left:0px;
          width:300px;
          height:100%;
          border-right:solid;
          border-color:rgba(0,22,22,0.4)
        }

        #navbar ul{
          height:88%;
          overflow-y:auto;
          overflow-x:hidden;
        } 

        #navbar li{
          color: #4e89aa;
          border:1px solid;
          border-bottom-width:0px;
          padding:8px;
          padding-left:45px;
          list-style: none;
          position:relative;
          left:-50px;
          width:100%;
        }
        #navbar a{
          text-decoration: none;
          cursor: pointer;
        }

        header{
          font-size: 30px;
          color: #0189d8;
          text-align: center;
          font-size: 1.9em;
          font-weight:normal;
        }

        #main-doc{
          position: absolute;
          margin-left:310px;
          padding:20px;
          margin-bottom:110px;
        }

        #main-doc header{
          text-align:left;
          margin:0px;
        }
        section article{
          margin:15px;
          font-size:0.96em;
        }

        section li{
          margin: 15px 0px 0px 30px;
        }

        code{
          display:block;
          text-align: left;
          white-space: pre;
          position: relative;
          word-break: normal;
          word-wrap: normal;
          line-height: 2;
          background-color:#f7f7f7;
          padding:15px;
          margin:10px;
          border-radius:5px;
        }

        @media only screen and (max-width: 815px) {
            /* For mobile phones: */
          #navbar ul{
            border:1px solid;
            height:207px;
          }
          #navbar{
            background-color:white;
            position:absolute;
            top:0;
            padding:0;
            margin: 0;
            width:100%;
            max-height:275px;
            border:none;
            z-index:1;
            border-bottom:2px solid;
          }
          #main-doc{
            position: relative;
            margin-left:0px;
            margin-top:270px;
          }
          #main-doc section {
            /*     padding-top: 240px; */
          }
        }

        @media only screen and (max-width: 400px) {
          #main-doc{
            margin-left:-10px;
          }
          code{
            margin-left:-20px;
            width:100%;
            padding:15px;
            padding-left:10px;
            padding-right:45px;
            min-width:233px;
          }
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <nav id="navbar">
      <header>C Languaje</header>
      <ul>
        <a class="nav-link" href="#Introduction"><li>Introduction</li></a>
        <a class="nav-link" href="#History"><li>History</li></a>
        <a class="nav-link" href="#Hello_World"><li>Hello World</li></a>
        <a class="nav-link" href="#Data_Types"><li>Data Types</li></a>
        <a class="nav-link" href="#Function_Declaration"><li>Function Declaration</li></a>
      </ul>
    </nav>
    <main id="main-doc">
      <section class="main-section" id="Introduction">
        <header>Introduction</header>
        <article>
          <p>C (/siː/, as in the letter c) is a general-purpose, imperative computer programming language, supporting structured programming, lexical variable scope and recursion, while a static type system prevents many unintended operations. By design, C provides constructs that map efficiently to typical machine instructions, and it has therefore found lasting use in applications that were previously coded in assembly language. Such applications include operating systems, as well as various application software for computers ranging from supercomputers to embedded systems.</p>
          <p>C is an imperative procedural language. It was designed to be compiled using a relatively straightforward compiler, to provide low-level access to memory, to provide language constructs that map efficiently to machine instructions, and to require minimal runtime support. Despite its low-level capabilities, the language was designed to encourage cross-platform programming. A standards-compliant C program that is written with portability in mind can be compiled for a wide variety of computer platforms and operating systems with few changes to its source code; the language has become available on various platforms, from embedded microcontrollers to supercomputers.</p>
        </article>
      </section>
      <section class="main-section" id="History">
        <header>History</header>
        <article>
          <p>In 1972, Ritchie started to improve B, which resulted in creating a new language C. C compiler and some utilities made by C were included in Version 2 Unix. At Version 4 Unix released at Nov. 1973, the Unix kernel was extensively re-implemented by C. By this time, the C language had acquired some powerful features such as struct types. </p>
          <li>1972 Birth of the C languaje.</li>
          <li>C18 is the actual standard. Published June 2018.</li>
          <p>Unix was one of the first operating system kernels implemented in a language other than assembly. Earlier instances include the Multics system (which was written in PL/I) and Master Control Program (MCP) for the Burroughs B5000 (which was written in ALGOL) in 1961. In around 1977, Ritchie and Stephen C. Johnson made further changes to the language to facilitate portability of the Unix operating system. Johnson's Portable C Compiler served as the basis for several implementations of C on new platforms.</p>
        </article>
      </section>
      <section class="main-section" id="Hello_World">
        <header>Hello World</header>
        <article>
          <p>For get started with writting C, open a text document rename it with ".c" and write your first "Hello World" C code:</p>
          <code>
            main()
            {
              printf("hello, world\n");
            }
            </code>
          <p>A standard-conforming "Hello World" program is:</p>
          <code>
            #include "stdio.h"
            int main(void)
            {
              printf("hello, world\n");
            }
          </code>
        </article>
      </section>
      <section class="main-section" id="Data_Types">
        <header>Data Types</header>
        <article>
          <p>Here we can see some of the data types most commons in C:</p>
          <li>char: Smallest addressable unit of the machine that can contain basic character set.</li>
          <li>int: Basic signed integer type. Capable of containing at least the [−32,767, +32,767] range; Thus, it is at least 16 bits in size.</li>
          <li>struct: Structures aggregate the storage of multiple data items, of potentially differing data types, into one memory block referenced by a single variable.</li>
          <code>
            struct birthday {
              char name[20];
              int day;
              int month;
              int year;
            };
            struct birthday John;</code>
          <li>arrys: An array is a collection of values, all of the same type, stored contiguously in memory. An array of size N is indexed by integers from 0 up to and including N−1.</li>
          <code>int cat[10];  // array of 10 elements, each of type int</code>
          <p>C is often used in low-level systems programming where escapes from the type system may be necessary. The compiler attempts to ensure type correctness of most expressions, but the programmer can override the checks in various ways, either by using a type cast to explicitly convert a value from one type to another, or by using pointers or unions to reinterpret the underlying bits of a data object in some other way.</p>
        </article>
      </section>
      <section class="main-section" id="Function_Declaration">
        <header>Function Declaration</header>
        <article>
          <p>Functions are used for managin the behavior of a program. They can be called by other functions for receving some type of data or for making something on the program.</p>
          <code>
            void print_age(int age){
              printf("Your age is: %d", age);
            }
            
            int main(){
              int n=0;
              scanf("Your age please: ", n);
              print_age(n);
             return 0;
            }
          </code>
          <p>On the example above the program print a string that is inside the function print_age that is called on the main function.</p>
        </article>
      </section>
    </main>
    </div>
</asp:Content>
