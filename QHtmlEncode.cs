// QHtmlEncode v1.0 (c) 2022 Sensei (aka 'Q')
// Reads stdin and encodes HTML entities.
//
// Usage:
// QHtmlEncode
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QHtmlEncode.cs

using System;
using System.Web;

public static class QHtmlEncode {
   public static void Main( string [] args ) {
      string row;
      while( ( row = Console.ReadLine() ) != null ) {
         Console.WriteLine( HttpUtility.HtmlEncode( row ) );
      }
   }
}
