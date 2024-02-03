#_Veri taşıma yöntemleri_

#Model ile veri taşıma yöntemi

*Controller'dan modele veri taşıma yöntemlerinden model ile veri taşıma yöntemi örneklerini yaptım.
*Gönderilecek veri Controllerda oluşturulmuş IActionResult değer view dönen metodlarının içinde return ile View() fonskisyonunda gönderilir.
*View(veri) içinde gönderilen veri view kısmında @ ile karşılanıp html kodların içinde kullanılabilir.


#ViewBag ile veri taşıma yöntemi

*Dinamik bir şekilde veriyi Controller'dan View'e taşır.
*Controller'da IActionResult değer dönen metodunda ViewBag.değişken_ismi = veri; şeklinde kullanılır.
*Bu yöntem ile gönderilen verilerin cinsi tutulmaz. 
*Viewde ise "@ViewBag.UserName" bu şekilde çağrlarak kullanılır.

#ViewData ile veri taşıma yöntemi

*ViewData key-value tarzında çalışır.
*ViewData["key"]=value; şeklinde tanımlanır.
*object tipinde veri tutar. Kullanılırken içindeki veriyi ToString() ile stringe veya ne ise ona dönüştürülüp kullanılmalıdır.

#TempData ile veri taşıma yöntemi

*İçerisinde object tipinde veri tuatar ve key-value mantığında çalışır.
*TempData["key"]=value; şeklinde kullanılır.
*Action'dan Action'a veri gönderebilir.

NOT: Büyük boyutlu veriler için model taşıma yöntemi tercih edilirken küçük boyutlu veriler için ViewBag, ViewData ve TempData gibi yöntemler kullanılır.

#View Model ile veri taşıma yöntemi

