import { Api } from "./api.js";
import { Korisnik } from "./korisnik.js";
import { Salon } from "./salon.js";

var api=new Api();
var salon=new Salon();
var listaRadnika=[];
let nalog;
salon= await api.vratiSalon();
listaRadnika= await api.vratiRadnike(salon.id)
console.log(listaRadnika);
//nalog=await api.PrijavaNaSajtUzVracanjeObjekta("Rade123","barabar");
var komentare= await api.vratiKomentare10(salon.id);
//var vlasnik= new Vlasnik();

console.log(komentare);
var selekcija=document.getElementById("komentari");
for(const kom of komentare)
{
  selekcija.innerHTML +=`
  <div class="swiper-slide"  >
  <div class="testimonial-item" >
    <p>
      <i class="bx bxs-quote-alt-left quote-icon-left"></i>
      ${kom.sadrzaj}
      <i class="bx bxs-quote-alt-right quote-icon-right"></i>
    </p>
    <img src="assets/img/user-photo.png" class="testimonial-img" alt="">
    <h3>${kom.korisnik}</h3>
    <h4>${kom.ocena}/5</h4>
    </div>
    </div>
 
`

}
var radnici=await api.vratiRadnike(salon.id);
selekcija=document.getElementById("radniciGlavnaStrana");
for(const radn of radnici)
{
  selekcija.innerHTML+=`
  <div class="col-lg-3 col-md-6 d-flex align-items-stretch">
            <div class="member" data-aos="fade-up">
              <div class="member-img">
                <img src="assets/img/user-photo.png" class="img-fluid" alt="">
                <div class="social">
                  <a href="https://twitter.com"><i class="bi bi-twitter"></i></a>
                  <a href="https://facebook.com"><i class="bi bi-facebook"></i></a>
                  <a href="https://instagram.com"><i class="bi bi-instagram"></i></a>
                  <a href="https://linkedin.com"><i class="bi bi-linkedin"></i></a>
                </div>
              </div>
              <div class="member-info">
                <h3>${radn.ime}</h3>
                <span><h4>${radn.tipRadnika}</h4></span>
              </div>
            </div>
          </div>
  `
}
document.getElementById("adresa").innerHTML=`${salon.adresa}`;

var Radnici=await api.vratiRadnikePoTipu("Frizer");


var selekcija2=document.getElementById("usluge4glavnap");
var usluge4=await api.vratiUslugePrazne4();
for(const usl of usluge4)
{
  selekcija2.innerHTML+=
  `
  <div class="col-lg-3 col-md-6">
            <div class="box" data-aos="zoom-in">
              <h3>PONUDA</h3>
              <h4><sup>RSD</sup>${usl.cena}<span> / <s>${usl.cena*2} RSD</s></span></h4>
              <ul>
                <li> </li>
                <li style="font-size:x-large">• ${usl.imeUsluge}</li>
                <li> </li>
                <li class="na"> </li> <!--uvek mozemo da dopisemo nesto ovde! :D-->
                <li class="na"> </li>
              </ul>
              <div class="btn-wrap">
                <a href="cenovnik-korisnik.html" class="btn-buy">Zakaži odmah</a>
              </div>
            </div>
          </div>
  `
}
