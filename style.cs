@-webkit-keyframes dot {
  0% {
    opacity: 0;
  }
  50% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
@keyframes dot {
  0% {
    opacity: 0;
  }
  50% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
#body_index {
  margin: 4% 10% 12% 10%;
}
#body_index section {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
  text-align: center;
  margin: 5%;
  text-decoration: none;
}
#body_index section .menu_accueil {
  margin: 5%;
  min-width: 450px;
  max-width: 450px;
  min-height: 600px;
  max-height: 600px;
  box-shadow: -2px 2px 15px 1px rgba(0, 0, 0, 0.5);
  border: 1px solid #f1f1f1;
  display: flex;
  flex-direction: column;
}
#body_index section .fa-music {
  font-size: 2em;
  background: linear-gradient(to right, #f04a5e 0%, #f8a183 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
#body_index .la_note_enchantee {
  background-color: #fcdfdb;
  color: #3c1218;
  font: bold 1.7em "Caveat", cursive;
  justify-content: center;
}
#body_index .le_chic_a_la_francaise {
  background-color: rgb 255, 245, 254;
  font: 1.5em "Merienda One", cursive;
  justify-content: center;
}
#body_index .le_chic_a_la_francaise h3 {
  background-image: linear-gradient(to bottom right, #d8852e 0%, #905bfd 100%);
  -webkit-background-clip: text;
  -webkit-background-clip: text;
  -moz-background-clip: text;
  background-clip: text;
  color: transparent;
}
#body_index .le_chic_a_la_francaise h2 {
  color: #c77412;
  font-family: "Lora", serif;
}
#body_index .le_delice_des_papilles {
  font-family: "Dancing Script", cursive;
  justify-content: center;
}
#body_index .le_delice_des_papilles h2 {
  font-family: "Kalam", cursive;
}
#body_index .la_palette_du_gout {
  font-family: "Merienda One", cursive;
  justify-content: center;
}
#body_index .la_palette_du_gout h2 {
  font-family: "Kalam", cursive;
}
#body_index .font_menu {
  font-family: "Caveat", cursive;
}

.button {
  background-color: #579c87;
  color: #fdcb46;
  font-size: 2em;
  text-align: center;
  width: 300px;
  height: 45px;
  margin: auto;
  border-radius: 5px;
}
.button .one {
  opacity: 0;
  -webkit-animation: dot 2s infinite;
  -webkit-animation-delay: 0s;
  animation: dot 1.3s infinite;
  animation-delay: 0s;
}
.button .two {
  opacity: 0;
  -webkit-animation: dot 2s infinite;
  -webkit-animation-delay: 0.2s;
  animation: dot 1.3s infinite;
  animation-delay: 0.3s;
}
.button .three {
  opacity: 0;
  -webkit-animation: dot 2s infinite;
  -webkit-animation-delay: 0.3s;
  animation: dot 1.3s infinite;
  animation-delay: 0.6s;
}

a {
  text-decoration: none;
}

header {
  font-family: "Archivo Black", sans-serif;
  font-size: 2em;
  background-color: #579c87;
  text-align: center;
  padding: 0.5%;
}
header .retour_index {
  color: #fdcb46;
  text-decoration: none;
}

footer {
  font-family: "Archivo Black", sans-serif;
  font-size: 2em;
  background-color: #579c87;
  position: fixed;
  bottom: 0;
  display: inline-block;
  width: 100%;
  height: 80px;
  padding-top: 40px;
}
footer .button_footer {
  display: flex;
  justify-content: space-between;
  padding-left: 40px;
  padding-right: 40px;
}
footer .effet {
  text-decoration: none;
  color: #fdcb46;
  display: flex;
}
footer .effet:hover {
  animation: wiggle 0.82s cubic-bezier(0.36, 0.07, 0.19, 0.97) both;
  transform: translate3d(0, 0, 0);
  backface-visibility: hidden;
  perspective: 1000px;
}

@keyframes wiggle {
  10%, 90% {
    transform: translate3d(-1px, 0, 0);
  }
  20%, 80% {
    transform: translate3d(2px, 0, 0);
  }
  30%, 50%, 70% {
    transform: translate3d(-4px, 0, 0);
  }
  40%, 60% {
    transform: translate3d(4px, 0, 0);
  }
}
.container {
  margin: 0 10% 10% 10%;
  text-align: center;
  font-size: 1.3em;
}
.container .titre {
  font-size: 1.5em;
}
.container .background_color_la_note_enchatee {
  background-color: #fcdfdb;
  margin: 0 10% 0 10%;
  padding: 5%;
  font-family: "Caveat", cursive;
}
.container .h1_LNE {
  text-align: center;
  font-size: 1.5em;
}
.container .left {
  text-align: left;
  clear: both;
}
.container .right {
  float: right;
  clear: both;
}
.container .line {
  display: flex;
  justify-content: space-between;
}
.container .line .line_left {
  background-color: black;
  clip-path: polygon(1% 41%, 26% 43%, 61% 43%, 100% 43%, 99% 49%, 65% 49%, 26% 47%, 0 48%);
  width: 25%;
}
.container .line .titre_center1 {
  font-size: 1.4em;
}
.container .line .titre_center2 {
  font-size: 1.4em;
}
.container .line .titre_center3 {
  font-size: 1.4em;
}
.container .line .line_right {
  background-color: black;
  clip-path: polygon(0 42%, 40% 40%, 95% 43%, 99% 49%, 40% 48%, 0 48%);
  width: 25%;
}
.container .last_title {
  display: flex;
  justify-content: center;
  vertical-align: middle;
  padding-top: 20px;
}
.container .fa-music {
  font-size: 4em;
  padding-right: 30px;
  background: linear-gradient(to right, #f04a5e 0%, #f8a183 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

#body_mentions {
  margin: 4% 10% 12% 10%;
}
#body_mentions h2 {
  text-align: center;
  text-decoration: underline;
  font-size: 2em;
}
#body_mentions p {
  text-align: justify;
}

/*# sourceMappingURL=style.cs.map */
