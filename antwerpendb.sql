-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: mysql212.hosting.combell.com
-- Gegenereerd op: 06 jun 2018 om 23:25
-- Serverversie: 5.7.20-18
-- PHP-versie: 5.6.17-0+deb8u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ID211210_antwerp`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `articles`
--

CREATE TABLE `articles` (
  `id` int(10) UNSIGNED NOT NULL,
  `title` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `text` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `blokID` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `articles`
--

INSERT INTO `articles` (`id`, `title`, `text`, `blokID`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Wat is seksuele intimidatie', 'We stelden Antwerpenaren op straat en experten dezelfde vraag: \"Wat is voor jou seksuele intimidatie?\" Niet iedereen ervaart seksuele intimidatie op dezelfde manier. Toch zijn er enkele kernwoorden die telkens terugkomen. </br></br>\r\n\r\nVoorbeelden van seksuele intimidatie:</br>\r\n- seksueel getinte of seksistische opmerkingen (ook via sms, sociale media …)</br>\r\n- obscene gebaren en geluiden</br>\r\n- handtastelijkheden en opdringerig gedrag</br>\r\n- gluren of nafluiten</br>\r\n- oneerbare voorstellen en intieme vragen </br>\r\n- ongevraagd in de billen knijpen of naar borsten grijpen</br>\r\n- uitschelden voor hoer, slet ...</br>\r\n- naast of achter een vrouw blijven lopen of de pas aanpassen aan die van de vrouw</br>\r\n- in groep rond een vrouw gaan staan</br>\r\n- ongevraagd filmen met een smartphone</br>\r\n...\r\n', 1, NULL, '2018-06-06 16:48:41', NULL),
(2, 'Doet niemand kwaad... - 14 Jaar', 'Ik laat onze honden uit samen met mijn zusje van 8. Er komt een man van eind 30 aangefietst. Hij blijft langzaam met ons meefietsen doorheen de amper bebouwde straten. Hij vertelt me dat hij me mooi vindt en een relatie met me wil. Ik negeer hem en probeer mij, mijn zusje en onze twee honden zo snel mogelijk veilig thuis te krijgen. Ik vertel alles aan mijn ouders, die met mij naar de politie gaan. De politie zegt dat ze hem kennen en dat hij niemand kwaad doet. Ik ben niemand, en mij lastigvallen is geen kwaad.', 2, NULL, NULL, NULL),
(3, 'Dagje naar het pretpark – 14 Jaar', 'Ik ga voor het eerst met leeftijdsgenoten zonder ouderlijke begeleiding naar een pretpark. Op de trein merk ik dat een groep jongens een paar banken verder mijn aandacht probeert te trekken. Ze maken pijp-gebaren en vragen me voor hoeveel ik beschikbaar ben. Ik steek mijn middelvinger op. De jongens staan op en komen naar me toe. Ze leunen even dreigend over me heen, en slaan dan abrupt in het gezicht van de enige jongen in ons gezelschap. Hij loopt de rest van de dag in Walibi rond met een blauw oog.', 2, NULL, NULL, NULL),
(4, 'Lekker chatten – 16 jaar', 'Ik ben een actief internetgebruiker en zoek sociale contacten op discussieforums. Ik maak geen geheim van mijn leeftijd. Ik maak seksueel getinte grapjes, zoals de meeste pubers. Ik heb binnen de week verschillende privé berichten van veel oudere mannen die me vertellen hoe ik hun verbeelding op hol doe slaan. Als ik de vleierij van twee van deze mannen afwijs, resulteert dit in een jaren aanslepende internet vete waarbij de mannen in kwestie zich profileren als een slachtoffer van mijn arrogantie en vrouwelijke charme. Ik voel me nog steeds onveilig als ik online een teken van leven van een van deze mannen opvang.', 2, NULL, NULL, NULL),
(5, 'Ritje met de trein – 18 jaar', 'Ik neem de trein en zit alleen in een coupé, overdag. Schuin tegenover me komt een man te zitten die opdringerig oogcontact probeert te maken. Hij begint te masturberen. Ik word kwaad en vertel hem dat hij zich moet schamen. Hij biedt zijn excuses aan. Twee minuten later gaat hij verder. Ik zeg hem dat ik de conducteur ga roepen. De man stapt bij de volgende halte af.', 2, NULL, NULL, NULL),
(6, 'Feestende mannen – 20 jaar', 'Ik probeer op een feestje naar de WC te gaan. Twee mannen van twee koppen groter beletten me de doorgang en vangen me in een sandwich van opdringerig testosteron. Ik slaag erin ze weg te duwen. Ze blijven nog een hele tijd naar me gluren, starend om mijn blik te vangen terwijl de twee onder elkaar staan te smoezen.', 2, NULL, NULL, NULL),
(7, '11.102', 'Het aantal aangiftes dat bij de politie werd gedaan in 2016 in verband met seksuele intimidatie. Als je dat omrekend, zijn dat ongeveer 30 meldingen per dag', 5, NULL, NULL, NULL),
(8, '17% en 12%', 'Het percentage van jongens en meisjes tussen 15 en 25 jaar dat aangifte durven doen na seksuele intimidatie. Bij oudere mensen (vanaf 25 jaar) is dat 13% voor de mannen en 19% bij de vrouwen.', 5, NULL, NULL, NULL),
(9, 'Dat noemt men pesten...', 'Jonge mannen (-17 jarigen) zullen (seksuele) intimidatie eerder gelijk stellen aan pestgedrag. Net zoals bij vrouwen, zullen jonge mannen veel gedragingen niet als seksueel intimideren ervaren als deze gebeuren  in een versiercontext.', 3, NULL, NULL, NULL),
(10, 'Verschil auto- en allochtoon', 'Toch spelen er (ook hier -net zoals bij de allochtone vrouwen) een aantal culturele elementen waardoor allochtone jonge mannen minder snel gedragingen als ongepast en seksueel intimiderend beschouwen dan autochtone jonge mannen. ', 3, NULL, NULL, '2018-05-16 17:08:36'),
(11, 'Zo vader ≠ zo zoon', 'In tegenstelling tot jongeren vinden volwassen mannen bepaalde fysieke aanrakingen (billen knijpen) zelfs aanvaardbaar zijn. Als ze gebeuren in een gemoedelijke en vriendschappelijke sfeer, onder collega’s of onder vrienden. ', 3, NULL, '2018-05-16 20:09:27', NULL),
(12, 'Haantjesgedrag', 'Bij jonge mannen worden bepaalde gedragingen ook vaak beschouwd als haantjesgedrag. Bepaalde van deze gedragingen worden ook gesteld onder groepsdruk: Niet zozeer om indruk te maken op vrouwen; Maar vooral om zich te bewijzen t.a.v. anderen jonge mannen. Bvb: Nafluiten of -roepen, ongewenst filmen, aanspreken met poepke of schatteke,… ', 3, NULL, NULL, NULL),
(14, 'Sexting', 'Als mensen seksueel getinte beelden, foto’s van zichzelf maken, verzenden, ontvangen of delen, noemen we dat sexting. Dat kan via smartphone, tablet of andere digitale media.\nHet begrip sexting is overgewaaid uit het Engels en is een samenstelling uit ‘sex’ (seks) en ‘texting’ (Engels voor sms’jes verzenden). Door de snelle ontwikkeling van gsm en andere technologieën, is sexting niet meer beperkt tot het verzenden van sms’jes. Seksueel getinte beelden en video’s kunnen ook via toepassingen op computers en smartphones gemaakt en doorgestuurd worden (zoals chatprogramma’s, dating en andere apps of sociaalnetwerksites).\nDe meeste jongeren gebruiken apps op de smartphone om aan sexting te doen. Ze vinden het praktisch omdat het zo makkelijk is om zo beelden de foto’s te nemen en te sturen. Bovendien hoeven ze hun smartphone ook niet met gezinsleden te delen, wat met tablets of computers soms wel het geval is.\nVerschillende vormen en gradaties van sexting komen voor bij kinderen, jongeren en volwassenen. Van pikante tekstberichtjes uitwisselen naar een vriend(in) tot een naaktfoto doorsturen naar anderen. Elke leeftijdsfase brengt andere oorzaken, kenmerken, maar ook gevolgen met zich mee. Het is een terechte bezorgdheid van opvoeders dat jongeren zichzelf of anderen geen schade zouden berokkenen. Of slachtoffer worden van online misbruik door volwassenen. Onderzoek toont gelukkig aan dat dit weinig voorkomt. \n', 4, NULL, NULL, NULL),
(15, 'Sextortion, wat is dat?', 'Bij sextortion (samentrekking van sexual extortion) of seksuele afpersing worden tieners via internet overtuigd om intieme beelden van zichzelf door te sturen, waarna de afpersers dreigen de beelden te verspreiden als het slachtoffer niet met geld over de brug komt. Sextortion is strafbaar, omdat het zowel afpersing als oplichting is.\r\nDe slachtoffers leven tot dan in de veronderstelling dat ze via internet bevriend zijn geraakt met een leeftijdgenoot, maar in werkelijkheid gaat het om criminele bendes. De tieners raken bijvoorbeeld via Facebook bevriend met die zogezegde leeftijdgenoot en na verloop van tijd krijgen de gesprekken een seksuele wending en overhaalt de crimineel het slachtoffer om intieme beelden van zichzelf door te sturen. Maar later komt dan de aap uit de mouw en krijgt de jongere het bericht dat de beelden openbaar zullen worden gemaakt als er niet snel geld wordt overgeschreven.\r\nHet meest eenvoudige advies dat we kunnen geven aan jongeren is dan ook om niet aan webcamseks te doen met onbekenden. We raden ten stelligste af om naaktfotos of intieme beelden van jezelf door te sturen.  Als het toch gebeurt, kan je best je gezicht niet tonen. Een tip is ook je webcam afdekken als je niet gefilmd wil worden. Maar als je toch het slachtoffer wordt, stap dan naar de politie en betaal vooral niet. Child Focus kan slachtoffers van sextortion bijstaan in de hele procedure. Ben je slachtoffer geworden of heb je hier vragen over, bel dan gerust het nummer van de hulplijn voor veilig internet van Child Focus 116 000, en wij zullen er alles aan doen om je verder te helpen. \r\n', 4, NULL, '2018-05-23 20:10:16', NULL),
(17, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 5, '2018-05-23 16:28:12', NULL, NULL),
(18, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 2, '2018-05-23 16:56:17', NULL, '2018-05-23 16:59:29'),
(19, 'Sextortion\'s, wat is dat?', 'test', 4, '2018-05-23 20:09:11', NULL, '2018-05-23 20:10:01'),
(20, 'Naast me in de klas - 12 Jaar', 'Mijn eerste weken in het eerste middelbaar worden gekenmerkt door mannelijke klasgenoten die om de beurt naast mij willen zitten. Onder de bank wrijven ze over mijn dijbeen. Sommige knijpen hard. Als ik kwaad word, vinden ze het pas echt grappig. De leerkracht doet niets.', 2, NULL, NULL, NULL),
(21, 'Het is nooit jouw schuld', 'Ongewenste intimiteiten of seksuele intimidatie lijken misschien onschuldig, maar kunnen zeer vervelend zijn, zeker als het herhaaldelijk gebeurt. Mensen gaan er zich ongemakkelijk, onzeker en onveilig door voelen. “Onthoud: het is nooit jouw schuld! En blijf er niet alleen mee zitten: praat erover, met de persoon die je lastigvalt of met mensen die je vertrouwt.” ', 1, '2018-06-06 16:26:35', NULL, NULL),
(22, 'Welk gedrag is strafbaar?', 'Ook al voelt niet iedereen zich even snel seksueel geïntimideerd, toch is ongewenst gedrag in bepaalde gevallen strafbaar.\r\nU kan persoonlijk aangifte doen, maar de politie kan ook zelf een vaststelling doen en een proces verbaal opmaken zonder dat er een klacht is ingediend. Het gaat hier om ongewenst, storend, intimiderend of choquerend gedrag dat seksueel getint of geladen kan zijn en waarbij het slachtoffer zich in zijn rust gestoord voelt. \r\n</br><br/>\r\nVoor dit soort strafbaar gedrag spreekt de wet over:</br>\r\n1. Belaging (Strafwetboek Art.442 bis): Alle gedrag dat de rust van de getroffen persoon ernstig verstoort zoals bijvoorbeeld achternalopen, omringen, intimiderende of beledigende sms-en of berichten op facebook sturen enzovoort.</br>\r\n2. Voyeurisme (Strafwetboek Art.371): Personen observeren of doen observeren, maar ook beelden of geluidsopnamen van iemand maken, zonder dat hij/zij dat weet of daarvoor toestemming heeft gegeven.\r\nAls dit gedrag wordt gesteld ten opzichte van minderjarigen, geldt dat als verzwarende omstandigheid en zijn ook de straffen zwaarder.', 1, '2018-06-06 16:31:42', '2018-06-06 16:37:17', NULL),
(23, 'Affiches in \'t Stad', 'In 2017 zei Antwerpen stop tegen seksuele intimidatie met een campagne in het straatbeeld onderneemt de stad Antwerpen actie tegen onaanvaardbaar en seksueel grensoverschrijdend gedrag. Met deze campagne wou de stad, net als in 2016, het onderwerp seksuele intimidatie bespreekbaar te maken. De affiches maken seksuele intimidatie zichtbaar in de straat. Ze zetten het thema nadrukkelijk op de kaart, maken het bespreekbaar én geven het signaal dat zo’n gedrag onaanvaardbaar is.\r\n</br></br>\r\nJa, het is een gevoelig thema, maar het verdient wel extra aandacht. Niet alleen omdat het vaak in het nieuws komt, maar vooral omdat de stad Antwerpen mannen en vrouwen ervan bewust wil maken dat seksueel intimiderend gedrag nooit aanvaardbaar is. Niemand zou zulk gedrag als ‘een deel van het dagelijks leven’ mogen zien. Het past niet in de open, hedendaagse, stedelijke cultuur die Antwerpen nastreeft.', 1, '2018-06-06 16:54:00', NULL, NULL),
(24, 'Aanpak op school', 'De stad wil meer zicht krijgen op hoe de problematiek in secundaire scholen leeft en een aanpak op maat uitwerken. Daarvoor maakte ze samen met Jong & van Zin een bevraging voor scholen op. 3 tot 4 scholen zouden mee in dit proefproject stappen. Bedoeling was de bevraging in oktober uit te voeren bij zowel leerlingen van de tweede en derde graad, leerkrachten als directie. \r\n</br></br>\r\nOp basis van de resultaten van de enquête, werkte Jong & van Zin een programma uit voor de betrokken scholen, dat zowel oog heeft voor de leerlingen als de leerkrachten/directie en dat zowel een preventief als een curatief luik heeft. Gepland wordt hiermee begin 2018 in de eerste scholen van start te gaan. Na evaluatie kan het project worden uitgerold in andere geïnteresseerde scholen.', 1, '2018-06-06 16:54:50', '2018-06-06 16:59:25', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `comments`
--

CREATE TABLE `comments` (
  `id` int(10) UNSIGNED NOT NULL,
  `comment` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_allowed` tinyint(1) NOT NULL DEFAULT '0',
  `user_id` int(10) UNSIGNED NOT NULL,
  `post_id` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `comments`
--

INSERT INTO `comments` (`id`, `comment`, `is_allowed`, `user_id`, `post_id`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Ja. Je bent 13, dus puberteit, dus hormonen.', 1, 6, 2, '2018-06-04 15:46:59', '2018-06-04 15:46:59', NULL),
(2, 'Hey, ik zou me daar niet al te veel zorgen over maken. Hij zal iedereen graag willen entertainen en daardoor lijkt hij heel aanhankelijk. Plezier in het leven is heel belangrijk ;)', 1, 6, 1, '2018-06-04 15:50:35', '2018-06-04 15:50:35', NULL),
(3, 'Heyy, dat je kleine borsten hebt is echt geen reden om onzeker te worden want iedereen heeft in het begin kleine borsten. Ik ook. Ik koop m\'n bhs gwn in de Etam ik heb wel 80a maar ik heb er ook al zien hangen voor jouw maat. Ook vind je der van alle leuke patronen, push-ups, gewone kleuren, felle kleuren,... 😊 Ik hoop dat je hier wat mee bent 💕💕💕💕', 1, 8, 3, '2018-06-04 15:52:48', '2018-06-04 15:52:48', NULL),
(4, 'Praat er misschien over met je ouders. Misschien moet je ook eens over praten met een dokter. Ik weet niet in welke mate je verlegen ben, maar het kan ook lichte sociale angst zijn. Een dokter kan je dan helpen en je verlegenheid verminderen.', 1, 7, 4, '2018-06-04 15:53:21', '2018-06-04 15:53:21', NULL),
(5, 'Hallo,\r\nIk snap je situatie zeer goed, en ik ben even oud als jij. Ik ben meestal verlegen als ik iets verkeerds heb gedaan en als ik weet dat zij het weten dat ik iets verkeerds deed...\r\nMaar je hoeft écht niet verlegen te zijn tegen je familie en ouders, komaan, ze zorgen voor je! Zelfs als je iets raars zegt of doet, zullen zij het zien als iemand die een kleine fout maakte, en fouten maken is niet erg, je leert ervan.\r\nIk heb wel 1 grote tip om minder verlegen te zijn, en dat is dat je meer moet praten met zowat iedereen. Zo word je spreekvaardig en ben je meer gemotiveerd om een gesprek te beginnen of om met een gesprek mee te doen. Zo heb ik mijn verlegenheid weggeholpen!\r\nIk hoop dat dit zal werken!\r\nGroets! x', 1, 8, 4, '2018-06-04 15:55:57', '2018-06-04 15:55:57', NULL),
(6, 'Hoi! Bedankt voor je snelle reactie, je hebt gelijk ik moet me gewoon amuseren :) Hopelijk heb ik volgende keer geen probleem meer met hoe hij is.', 1, 3, 1, '2018-06-04 16:25:26', '2018-06-04 16:25:26', NULL),
(7, 'bedankt voor je reactie maar heb net gekeken op hun site en de kleinste maat die je kan kiezen is 80a. jammer maar toch bedankt iemand anders nog winkels waar ze 65/70a hebben ?', 1, 5, 3, '2018-06-04 16:26:18', '2018-06-04 16:26:18', NULL),
(8, 'Oh ik heb het ook als ik een mooie jongen zie en het ergste is dat ik me dat gewoon inbeeld hoe dat zou zijn haha, ik heb ook zin in seks.', 1, 5, 2, '2018-06-04 16:26:44', '2018-06-04 16:26:44', NULL),
(9, 'Ik weet het niet zeker, maar ik denk hunkëmoller. \r\nKijk zeker een op hun website! \r\nGrtjs en veel geluk met de zoektocht', 1, 8, 3, '2018-06-04 16:30:39', '2018-06-04 16:30:39', NULL),
(10, 'Heey!\r\n\r\nWenen na een kamp Cry, dat is minder natuurlijk maar wij denken dat het komt omdat je dan de andere kampgangers moet missen. Als je het tijdens het kamp naar je zin hebt gehad en je hebt je goed geamuseerd met de anderen, dan is het wel vrij normaal dat je wat verdrietig bent omdat je ze mist. Dat is ook niks om je over te schamen of om te denken dat het niet normaal is.\r\nKan je niet in contact blijven met de andere kampgangers? Tegenwoordig zijn er toch mogelijkheden genoeg: skype, FB, snapchat, What\'sapp, sms,...\r\n\r\nHebben andere jongeren hier ook wel eens mee te maken (gehad)? en zo ja, wat deed je er dan aan?\r\n\r\nVeel liefs en een hele dikke troostende knuffel van ons!', 1, 9, 5, '2018-06-04 16:36:33', '2018-06-04 16:36:33', NULL),
(11, 'Dit is helemaal normaal, op deze leeftijd gaan je hormonen flink te keer! Als meisje kan je het wel eens meemaken dat oudere jongens naar je borsten zitten te kijken. Zorg alleen dat als je kijkt het niet te veel opvalt. Anders wordt dat heel ongemakkelijk voor jou en degene naar wie je kijkt.', 1, 9, 2, '2018-06-04 16:39:29', '2018-06-04 16:39:29', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2018_03_01_151036_create_articles_table', 1),
(4, '2018_03_01_151130_create_posts_table', 1),
(5, '2018_03_01_151143_create_comments_table', 1),
(6, '2018_04_19_133823_create_quotes_table', 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `posts`
--

CREATE TABLE `posts` (
  `id` int(10) UNSIGNED NOT NULL,
  `title` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_allowed` tinyint(1) NOT NULL DEFAULT '0',
  `user_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `posts`
--

INSERT INTO `posts` (`id`, `title`, `description`, `is_allowed`, `user_id`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Hoe reageer ik?', 'Ik heb een leraar (van mijn hobby) en hij heeft een gezin. hij is echt een leuke man (geen douchebag, niet arrogant en altijd vrolijk) maar ik vraag me soms af wat hij denkt. hij lacht met iedereen (wat hem cool maakt) en ik weet dat alles wat hij zegt niet serieus is, maar ik weet nooit hoe ik moet reageren op hem. ik ben niet met mannen/jongens opgegroeid.\r\n\r\nHij zegt dat hij me niet kan aflezen (ik ben introvert). Hij maakt grapjes over mij ten huwelijk vragen, hij probeert me om me te laten flirten met andere hobbygenoten en gisteren vroeg hij me of ik me ging omkleden na de les. het is een buitenhobby dus het was gewoon op straat dat ik me moest omkleden. hij zat al in zijn auto klaar om naar huis te rijden (en had een passagier mee). Ik zei ja en hij zei daarop ‘Okay, ik zal wachten en kijken’. Hij wachtte effectief en keek doodserieus in zn zijspiegel naar mij. ik moest niet naakt gaan, gwn ondergoed. Op zich niet erg, maar toch.. en ik ben 18+ dus niet illegaal.\r\n\r\nnormaal lacht hij altijd omdat hij zichzelf amuseert als iemand doet wat hij vraagt. hij is het dan ook gewoon dat mensen zijn mopjes uitvoeren. maar gisteren keek hij dooderieus door zijn zijspiegel naar mij. en hij bleef wachten. \r\n\r\nuiteindelijk zei ik dat ik me later zou omkleden en zei ik salut. hij reed weg en ik heb me toen omgekleed. Er stond nog een man bij maar dat deed me niks want hij zei er niets van en keek ook niet.\r\n\r\nik weet dat hij maar grapte en wss gebeurd dit ook niet meer maar ik vond het heel awkward. hij is op zich tof maar dat was heel awkward, omdat hij zo serieus bleef. ik weet ook algemeen nooit hoe ik op hem moet reageren. \r\n\r\n\r\nwat dacht hij toen? Wat zou ik in het vervolg doen? ik wil er niet echt officieel over praten omdat ik er geen big deal van wil maken. hij is er ook niet mee bezig. maar wat kan ik doen in het vergolg? ik kan hem niet altijd goed inschatten. Danku', 1, 3, '2018-06-04 15:22:45', '2018-06-04 16:16:31', NULL),
(2, 'Veel zin', 'Hey allemaal,\r\n\r\nIk ben een jongen van 13 en de laatste tijd als ik knap meisje zie of een mooie kont heb ik ZOVEEL zin in seks\r\nIs dit wel normaal?!', 1, 4, '2018-06-04 15:32:33', '2018-06-04 15:32:33', NULL),
(3, 'Kleine borsten', 'Ik heb erg kleine borsten en ben hier erg onzeker over vooral omdat in bijna alle winkels deze bhs bij de kinderen hangen en heel kinderachtig zijn. Ik heb maat 65/70 a. Ik wil gewoon normale witte of zwarte bh\'s en liefst een beetje push up ofzo. Er zijn veel jongens die er ook overduidelijk naar kijken of stiekem mee aan het lachen zijn. Weet iemand winkels waar ik zo\'n bhs kan vinden?', 1, 5, '2018-06-04 15:41:47', '2018-06-04 15:41:47', NULL),
(4, 'Verlegen voor iedereen', 'Ik ben een jongen van 13 en ik ben al heel mijn leven verlegen zelfs tegen kennissen en familie, tegen men vriendinnen niet! Ik durf ook nooit iets te gaan vragen aan men leerkracht ook al snap ik er niks van ik durf het niet te vragen. Het lijkt of ze me altijd raar aankijken en ik denk dat ze naar mijn achterwerk kijken. Hebben jullie tips?', 1, 6, '2018-06-04 15:45:47', '2018-06-04 15:45:47', NULL),
(5, 'Wenen na kamp', 'Hey awel . Dus ik heb een probleempje. Ik ween altijd na een kamp . De laatste 2 Dagen van het kamp krijg ik het altijd moeilijk. Ik denk dat het te maken heeft dat meisjes me vaak uitlachen met mijn gestalte. Ik ben namelijk nog redelijk klein voor mijn leeftijd. Gelukkig was er een begeleider om mij komen troosten. Is dit normaal ? En waarom heb ik het er zo moeilijk mee...? 😶', 1, 7, '2018-06-04 16:34:55', '2018-06-04 16:34:55', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quotes`
--

CREATE TABLE `quotes` (
  `id` int(10) UNSIGNED NOT NULL,
  `quote` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `blokID` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `quotes`
--

INSERT INTO `quotes` (`id`, `quote`, `blokID`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, '\"Seksuele intimidatie zijn seksueel getinte gebaren, woorden, aanrakingen die je ongemakkelijk doen voelen.\" - Sensoa', 1, NULL, NULL, NULL),
(2, '\"Soms hebben mensen de kracht niet meer om het gevecht om rechtvaardigheid aan te gaan en dat is heel begrijpelijk.\" - InfoNu', 2, NULL, NULL, NULL),
(3, '\"Seksuele intimidatie hoeft niet per se lichamelijk te zijn.\" - Jobat', 3, NULL, NULL, '2018-05-23 19:53:08'),
(4, '\"Indien de seksuele intimidatie hinderlijk betasten is kan men ook spreken van aanranding.\" - Wikipedia', 4, NULL, '2018-05-16 20:23:36', NULL),
(5, 'Seksuele intimidatie op het werk en op andere openbare plaatsen kan ook bestraft worden op basis van de seksismewet. - Instituut voor de Gelijkheid van Vrouwen en Mannen', 3, '2018-05-23 19:55:15', NULL, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lastName` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `username` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_admin` tinyint(1) NOT NULL DEFAULT '0',
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Gegevens worden geëxporteerd voor tabel `users`
--

INSERT INTO `users` (`id`, `name`, `lastName`, `email`, `username`, `password`, `is_admin`, `remember_token`, `created_at`, `updated_at`) VALUES
(3, 'Marie', 'Verhoeven', 'marie.verhoeven@gmail.com', 'MaariV', '$2y$10$s0LJY6JygGt1U2Oxotr8ROSjoB6HAJpCrmB9tI3v49wOTcYIRz6dO', 0, '2QzIME48zjkmr2N1v6Zzha3Dey55GibecPNDVXOKrtXf3a54LnK2Wfncako8', '2018-06-03 17:08:51', '2018-06-03 17:08:51'),
(4, 'David', 'Van den Bergh', 'david.vandenbergh@gmail.com', 'Bergje', '$2y$10$lV3.dpZIJWXZ3qZtzgtNweicKStvYqbClHqKG3qTyevciWxa73Vpe', 0, 'goS935AhRAy4FJPpev6AsGVnwt5BksAnrePhTrBoAjjss2p5g9Fag3HvrTuQ', '2018-06-04 15:32:10', '2018-06-04 15:32:10'),
(5, 'Ellen', 'Mit', 'ellen.mit@gmail.com', 'MittE', '$2y$10$kkQ9Y59OZMfL3uvmvkp3lelYkxr30QN80JEd9OHUiQKzCN3YA7f9q', 0, 'IbiE9BOTAZOAr4QjyoqWRSwLA4ACrbdvT0NTuhusctT26K7n2I6kA7BO0Pp7', '2018-06-04 15:40:17', '2018-06-04 15:40:17'),
(6, 'Lukas', 'Janssens', 'lukas.janssens@gmail.com', 'Lukieluk', '$2y$10$Siicu8CdAIolLq4xd4iTI.oEIi9FathiKoMny08t4AXT9Jm0fbeji', 0, 'edjuieyUZi68mUEQxixaI4NkQ7RzANwtt4QPjwzhk1cqS2X06nQsVNNja20L', '2018-06-04 15:44:34', '2018-06-04 15:44:34'),
(7, 'Pieter', 'De Vos', 'pieter.devos@gmail.com', 'Voske2', '$2y$10$PexgMgzn3hT3.8Yg21XyZuUDjx9KKy6csHsPMuUwWBWNNyDHve8lW', 0, 'heeL6VnnAVgg2j6svyG2vlt4vbKqtzsQ4yAZUaD4aAqV1MRbYl3bp8d9gm7C', '2018-06-04 15:51:32', '2018-06-04 15:51:32'),
(8, 'Sophie', 'Collaert', 'sophie.collaert@gmail.com', 'Soffeke', '$2y$10$2fQ1mWvjroskNWbd97B62.vrQC2gQZi/oJwfbmp0hlXaWrbMU/4mu', 0, '2XoETiXWE5teoax5kWc9CUeITxC7i2i3nkH60LICLa4VOAeM05ZBiNwUNWrr', '2018-06-04 15:53:58', '2018-06-04 15:53:58'),
(9, 'Angela', 'Van Moer', 'angela.vanmoer@gmail.com', 'Angela', '$2y$10$8KgVH0Cy0x6P9TSYgggoOOMdEEFa7nPZtyj4D0CTjeYNx.l9ju3qe', 1, 'Io79QTjUsMTD2S74KZVm2WTbeDS4QtqsHBbA5PFKMuHRozoH19EaY9afRj0n', '2018-06-04 16:36:07', '2018-06-04 16:36:07'),
(10, 'Roel', 'Op de Beeck', 'roel.opdebeeck@gmail.com', 'Administrator_1', '$2y$10$Vh/0KULGS.ZSd2fe1Pb1nuUI0pobdTPtFBSo9UCwG1mdEFdNOX6Iu', 1, '2EutEfyrPEgKLTayZsphsNtonmx8Dtes0oK1cpQSuaNRdvXHwy2MUV68tgUS', '2018-06-06 08:23:09', '2018-06-06 08:23:09'),
(11, 'Leen', 'De Bakker', 'leen.debakker@gmail.com', 'Administrator_2', '$2y$10$3av76eTaphNgSYYqVddfmOOnjGLuNAoBaAmMvY3iokpRGzbC4MPku', 1, 'z1uBn9iO7Qqw7RLL21eVECCYuvKm6KJNewgv0ZtiTZr9TpwPrXEkTOJ3AhsM', '2018-06-06 08:24:47', '2018-06-06 08:24:47');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `comments_user_id_foreign` (`user_id`),
  ADD KEY `comments_post_id_foreign` (`post_id`);

--
-- Indexen voor tabel `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Indexen voor tabel `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `quotes`
--
ALTER TABLE `quotes`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `articles`
--
ALTER TABLE `articles`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT voor een tabel `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT voor een tabel `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT voor een tabel `posts`
--
ALTER TABLE `posts`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT voor een tabel `quotes`
--
ALTER TABLE `quotes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT voor een tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_post_id_foreign` FOREIGN KEY (`post_id`) REFERENCES `posts` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `comments_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
