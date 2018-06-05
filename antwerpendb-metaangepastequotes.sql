-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 30 mei 2018 om 15:36
-- Serverversie: 10.1.26-MariaDB
-- PHP-versie: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `antwerpendb`
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
(1, 'Naast me in de klas - 12 Jaar', 'Mijn eerste weken in het eerste middelbaar worden gekenmerkt door mannelijke klasgenoten die om de beurt naast mij willen zitten. Onder de bank wrijven ze over mijn dijbeen. Sommige knijpen hard. Als ik kwaad word, vinden ze het pas echt grappig. De leerkracht doet niets.', 1, NULL, NULL, NULL),
(2, 'Doet niemand kwaad... - 14 Jaar', 'Ik laat onze honden uit samen met mijn zusje van 8. Er komt een man van eind 30 aangefietst. Hij blijft langzaam met ons meefietsen doorheen de amper bebouwde straten. Hij vertelt me dat hij me mooi vindt en een relatie met me wil. Ik negeer hem en probeer mij, mijn zusje en onze twee honden zo snel mogelijk veilig thuis te krijgen. Ik vertel alles aan mijn ouders, die met mij naar de politie gaan. De politie zegt dat ze hem kennen en dat hij niemand kwaad doet. Ik ben niemand, en mij lastigvallen is geen kwaad.', 1, NULL, NULL, NULL),
(3, 'Dagje naar het pretpark – 14 Jaar', 'Ik ga voor het eerst met leeftijdsgenoten zonder ouderlijke begeleiding naar een pretpark. Op de trein merk ik dat een groep jongens een paar banken verder mijn aandacht probeert te trekken. Ze maken pijp-gebaren en vragen me voor hoeveel ik beschikbaar ben. Ik steek mijn middelvinger op. De jongens staan op en komen naar me toe. Ze leunen even dreigend over me heen, en slaan dan abrupt in het gezicht van de enige jongen in ons gezelschap. Hij loopt de rest van de dag in Walibi rond met een blauw oog.', 1, NULL, NULL, NULL),
(4, 'Lekker chatten – 16 jaar', 'Ik ben een actief internetgebruiker en zoek sociale contacten op discussieforums. Ik maak geen geheim van mijn leeftijd. Ik maak seksueel getinte grapjes, zoals de meeste pubers. Ik heb binnen de week verschillende privé berichten van veel oudere mannen die me vertellen hoe ik hun verbeelding op hol doe slaan. Als ik de vleierij van twee van deze mannen afwijs, resulteert dit in een jaren aanslepende internet vete waarbij de mannen in kwestie zich profileren als een slachtoffer van mijn arrogantie en vrouwelijke charme. Ik voel me nog steeds onveilig als ik online een teken van leven van een van deze mannen opvang.', 1, NULL, NULL, NULL),
(5, 'Ritje met de trein – 18 jaar', 'Ik neem de trein en zit alleen in een coupé, overdag. Schuin tegenover me komt een man te zitten die opdringerig oogcontact probeert te maken. Hij begint te masturberen. Ik word kwaad en vertel hem dat hij zich moet schamen. Hij biedt zijn excuses aan. Twee minuten later gaat hij verder. Ik zeg hem dat ik de conducteur ga roepen. De man stapt bij de volgende halte af.', 1, NULL, NULL, NULL),
(6, 'Feestende mannen – 20 jaar', 'Ik probeer op een feestje naar de WC te gaan. Twee mannen van twee koppen groter beletten me de doorgang en vangen me in een sandwich van opdringerig testosteron. Ik slaag erin ze weg te duwen. Ze blijven nog een hele tijd naar me gluren, starend om mijn blik te vangen terwijl de twee onder elkaar staan te smoezen.', 1, NULL, NULL, NULL),
(7, '11.102', 'Het aantal aangiftes dat bij de politie werd gedaan in 2016 in verband met seksuele intimidatie. Als je dat omrekend, zijn dat ongeveer 30 meldingen per dag', 2, NULL, NULL, NULL),
(8, '17% en 12%', 'Het percentage van jongens en meisjes tussen 15 en 25 jaar dat aangifte durven doen na seksuele intimidatie. Bij oudere mensen (vanaf 25 jaar) is dat 13% voor de mannen en 19% bij de vrouwen.', 2, NULL, NULL, NULL),
(9, 'Dat noemt men pesten...', 'Jonge mannen (-17 jarigen) zullen (seksuele) intimidatie eerder gelijk stellen aan pestgedrag. Net zoals bij vrouwen, zullen jonge mannen veel gedragingen niet als seksueel intimideren ervaren als deze gebeuren  in een versiercontext.', 3, NULL, NULL, NULL),
(10, 'Verschil auto- en allochtoon', 'Toch spelen er (ook hier -net zoals bij de allochtone vrouwen) een aantal culturele elementen waardoor allochtone jonge mannen minder snel gedragingen als ongepast en seksueel intimiderend beschouwen dan autochtone jonge mannen. ', 3, NULL, NULL, '2018-05-17 07:08:36'),
(11, 'Zo vader ≠ zo zoon', 'In tegenstelling tot jongeren vinden volwassen mannen bepaalde fysieke aanrakingen (billen knijpen) zelfs aanvaardbaar zijn. Als ze gebeuren in een gemoedelijke en vriendschappelijke sfeer, onder collega’s of onder vrienden. ', 3, NULL, '2018-05-17 10:09:27', NULL),
(12, 'Haantjesgedrag', 'Bij jonge mannen worden bepaalde gedragingen ook vaak beschouwd als haantjesgedrag. Bepaalde van deze gedragingen worden ook gesteld onder groepsdruk: Niet zozeer om indruk te maken op vrouwen; Maar vooral om zich te bewijzen t.a.v. anderen jonge mannen. Bvb: Nafluiten of -roepen, ongewenst filmen, aanspreken met poepke of schatteke,… ', 3, NULL, NULL, NULL),
(13, 'Wat is seksuele intimidatie', 'Moet nog ingevuld worden lol', 4, NULL, NULL, NULL),
(14, 'Sexting', 'Als mensen seksueel getinte beelden, foto’s van zichzelf maken, verzenden, ontvangen of delen, noemen we dat sexting. Dat kan via smartphone, tablet of andere digitale media.\nHet begrip sexting is overgewaaid uit het Engels en is een samenstelling uit ‘sex’ (seks) en ‘texting’ (Engels voor sms’jes verzenden). Door de snelle ontwikkeling van gsm en andere technologieën, is sexting niet meer beperkt tot het verzenden van sms’jes. Seksueel getinte beelden en video’s kunnen ook via toepassingen op computers en smartphones gemaakt en doorgestuurd worden (zoals chatprogramma’s, dating en andere apps of sociaalnetwerksites).\nDe meeste jongeren gebruiken apps op de smartphone om aan sexting te doen. Ze vinden het praktisch omdat het zo makkelijk is om zo beelden de foto’s te nemen en te sturen. Bovendien hoeven ze hun smartphone ook niet met gezinsleden te delen, wat met tablets of computers soms wel het geval is.\nVerschillende vormen en gradaties van sexting komen voor bij kinderen, jongeren en volwassenen. Van pikante tekstberichtjes uitwisselen naar een vriend(in) tot een naaktfoto doorsturen naar anderen. Elke leeftijdsfase brengt andere oorzaken, kenmerken, maar ook gevolgen met zich mee. Het is een terechte bezorgdheid van opvoeders dat jongeren zichzelf of anderen geen schade zouden berokkenen. Of slachtoffer worden van online misbruik door volwassenen. Onderzoek toont gelukkig aan dat dit weinig voorkomt. \n', 4, NULL, NULL, NULL),
(15, 'Sextortion, wat is dat?', 'Bij sextortion (samentrekking van sexual extortion) of seksuele afpersing worden tieners via internet overtuigd om intieme beelden van zichzelf door te sturen, waarna de afpersers dreigen de beelden te verspreiden als het slachtoffer niet met geld over de brug komt. Sextortion is strafbaar, omdat het zowel afpersing als oplichting is.\r\nDe slachtoffers leven tot dan in de veronderstelling dat ze via internet bevriend zijn geraakt met een leeftijdgenoot, maar in werkelijkheid gaat het om criminele bendes. De tieners raken bijvoorbeeld via Facebook bevriend met die zogezegde leeftijdgenoot en na verloop van tijd krijgen de gesprekken een seksuele wending en overhaalt de crimineel het slachtoffer om intieme beelden van zichzelf door te sturen. Maar later komt dan de aap uit de mouw en krijgt de jongere het bericht dat de beelden openbaar zullen worden gemaakt als er niet snel geld wordt overgeschreven.\r\nHet meest eenvoudige advies dat we kunnen geven aan jongeren is dan ook om niet aan webcamseks te doen met onbekenden. We raden ten stelligste af om naaktfotos of intieme beelden van jezelf door te sturen.  Als het toch gebeurt, kan je best je gezicht niet tonen. Een tip is ook je webcam afdekken als je niet gefilmd wil worden. Maar als je toch het slachtoffer wordt, stap dan naar de politie en betaal vooral niet. Child Focus kan slachtoffers van sextortion bijstaan in de hele procedure. Ben je slachtoffer geworden of heb je hier vragen over, bel dan gerust het nummer van de hulplijn voor veilig internet van Child Focus 116 000, en wij zullen er alles aan doen om je verder te helpen. \r\n', 4, NULL, '2018-05-17 07:44:52', NULL),
(17, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 2, '2018-05-24 06:28:12', NULL, NULL),
(18, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 2, '2018-05-24 06:56:17', NULL, '2018-05-24 06:59:29');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `comments`
--

CREATE TABLE `comments` (
  `id` int(10) UNSIGNED NOT NULL,
  `comment` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `post_id` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

--
-- Gegevens worden geëxporteerd voor tabel `password_resets`
--

INSERT INTO `password_resets` (`email`, `token`, `created_at`) VALUES
('admin@admin.be', '$2y$10$I.NSSPwp9dVio2zEyhwg/O0SCwC0jEoAcRSUSMHkfP.vlHyKtBzwu', '2018-05-24 05:56:33');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `posts`
--

CREATE TABLE `posts` (
  `id` int(10) UNSIGNED NOT NULL,
  `title` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `text` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
(3, '\"Seksuele intimidatie hoeft niet per se lichamelijk te zijn.\" - Jobat', 3, NULL, NULL, '2018-05-24 07:53:08'),
(4, '\"Indien de seksuele intimidatie hinderlijk betasten is kan men ook spreken van aanranding.\" - Wikipedia', 4, NULL, '2018-05-17 08:23:36', '2018-05-24 09:27:20'),
(5, 'Seksuele intimidatie op het werk en op andere openbare plaatsen kan ook bestraft worden op basis van de seksismewet. - Instituut voor de Gelijkheid van Vrouwen en Mannen', 3, '2018-05-24 07:55:15', NULL, NULL),
(6, 'Een dubbelzinnige opmerking, een hand op je dij, een pikante foto in je mailbox ,... Voor de een is het over de grens, voor de ander niet. - Seksualiteit.be', 4, '2018-05-24 09:27:12', NULL, NULL);

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
(2, 'admin', 'admin', 'admin@admin.be', 'admin', '$2y$10$AtxXrszf8/MOn6QbgBX7nuPV3u3k6d/XgJOFBMZZNpBwjH3vA0z9y', 1, 'yDesJwc5evPN1onfBUX4hR3nzIS2puxexFfcikoD136TkSb4lFF9oyFleTWe', '2018-04-26 11:07:48', '2018-04-26 11:07:48'),
(3, 'Indy', 'Bosschem', 'indy.bosschem@gmail.com', 'Indy', '$2y$10$ylymKLXyb37XyT22.t0Xk.MRsbRLbsuQew3xTjjTx8JCRDe8NrJN2', 0, 'euHbagD5FM5xMIVNV5bHMPnAiSOG71PHK1Yj79KkVlDoFvCBdZ5mCMzT6yvE', '2018-04-26 11:42:08', '2018-04-26 11:42:08'),
(4, 'Vincent', 'Van Minnebruggen', 'vincent@vincent.be', 'vincent', '$2y$10$Ar1LOQJehQ1WMSOp9SMUIufizY6Pi/3PSgJRSy0fpfjh8n7WF9Znq', 0, 'in6bw6QpQ2JjBnh4d8CPdyahtQzZcKx0YzapTpA9SGMXUi7fMFKDbS8Un1CM', '2018-05-03 11:11:02', '2018-05-03 11:11:02'),
(5, 'Arthur', 'Van Passel', 'arthur@arthur.be', 'arthur', '$2y$10$UzO7koOhlTo7DI61UyAwDO8OFSMTmZqYTrtNpxzBDhpjewisaTdKe', 0, 'idzkvWiu75mfWOaSB2LXuOuzKewmFmzRWOWtnIUHYgJgK0WIndYHrDFfcdpx', '2018-05-17 07:31:05', '2018-05-17 07:31:05');

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
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT voor een tabel `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT voor een tabel `posts`
--
ALTER TABLE `posts`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `quotes`
--
ALTER TABLE `quotes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT voor een tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_post_id_foreign` FOREIGN KEY (`post_id`) REFERENCES `posts` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
