-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 30, 2018 at 01:20 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `AntwerpenDB`
--

-- --------------------------------------------------------

--
-- Table structure for table `articles`
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
-- Dumping data for table `articles`
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
(10, 'Verschil auto- en allochtoon', 'Toch spelen er (ook hier -net zoals bij de allochtone vrouwen) een aantal culturele elementen waardoor allochtone jonge mannen minder snel gedragingen als ongepast en seksueel intimiderend beschouwen dan autochtone jonge mannen. ', 3, NULL, NULL, '2018-05-17 03:08:36'),
(11, 'Zo vader ≠ zo zoon', 'In tegenstelling tot jongeren vinden volwassen mannen bepaalde fysieke aanrakingen (billen knijpen) zelfs aanvaardbaar zijn. Als ze gebeuren in een gemoedelijke en vriendschappelijke sfeer, onder collega’s of onder vrienden. ', 3, NULL, '2018-05-17 06:09:27', NULL),
(12, 'Haantjesgedrag', 'Bij jonge mannen worden bepaalde gedragingen ook vaak beschouwd als haantjesgedrag. Bepaalde van deze gedragingen worden ook gesteld onder groepsdruk: Niet zozeer om indruk te maken op vrouwen; Maar vooral om zich te bewijzen t.a.v. anderen jonge mannen. Bvb: Nafluiten of -roepen, ongewenst filmen, aanspreken met poepke of schatteke,… ', 3, NULL, NULL, NULL),
(13, 'Wat is seksuele intimidatie', 'Moet nog ingevuld worden lol', 4, NULL, NULL, NULL),
(14, 'Sexting', 'Als mensen seksueel getinte beelden, foto’s van zichzelf maken, verzenden, ontvangen of delen, noemen we dat sexting. Dat kan via smartphone, tablet of andere digitale media.\nHet begrip sexting is overgewaaid uit het Engels en is een samenstelling uit ‘sex’ (seks) en ‘texting’ (Engels voor sms’jes verzenden). Door de snelle ontwikkeling van gsm en andere technologieën, is sexting niet meer beperkt tot het verzenden van sms’jes. Seksueel getinte beelden en video’s kunnen ook via toepassingen op computers en smartphones gemaakt en doorgestuurd worden (zoals chatprogramma’s, dating en andere apps of sociaalnetwerksites).\nDe meeste jongeren gebruiken apps op de smartphone om aan sexting te doen. Ze vinden het praktisch omdat het zo makkelijk is om zo beelden de foto’s te nemen en te sturen. Bovendien hoeven ze hun smartphone ook niet met gezinsleden te delen, wat met tablets of computers soms wel het geval is.\nVerschillende vormen en gradaties van sexting komen voor bij kinderen, jongeren en volwassenen. Van pikante tekstberichtjes uitwisselen naar een vriend(in) tot een naaktfoto doorsturen naar anderen. Elke leeftijdsfase brengt andere oorzaken, kenmerken, maar ook gevolgen met zich mee. Het is een terechte bezorgdheid van opvoeders dat jongeren zichzelf of anderen geen schade zouden berokkenen. Of slachtoffer worden van online misbruik door volwassenen. Onderzoek toont gelukkig aan dat dit weinig voorkomt. \n', 4, NULL, NULL, NULL),
(15, 'Sextortion, wat is dat?', 'Bij sextortion (samentrekking van sexual extortion) of seksuele afpersing worden tieners via internet overtuigd om intieme beelden van zichzelf door te sturen, waarna de afpersers dreigen de beelden te verspreiden als het slachtoffer niet met geld over de brug komt. Sextortion is strafbaar, omdat het zowel afpersing als oplichting is.\r\nDe slachtoffers leven tot dan in de veronderstelling dat ze via internet bevriend zijn geraakt met een leeftijdgenoot, maar in werkelijkheid gaat het om criminele bendes. De tieners raken bijvoorbeeld via Facebook bevriend met die zogezegde leeftijdgenoot en na verloop van tijd krijgen de gesprekken een seksuele wending en overhaalt de crimineel het slachtoffer om intieme beelden van zichzelf door te sturen. Maar later komt dan de aap uit de mouw en krijgt de jongere het bericht dat de beelden openbaar zullen worden gemaakt als er niet snel geld wordt overgeschreven.\r\nHet meest eenvoudige advies dat we kunnen geven aan jongeren is dan ook om niet aan webcamseks te doen met onbekenden. We raden ten stelligste af om naaktfotos of intieme beelden van jezelf door te sturen.  Als het toch gebeurt, kan je best je gezicht niet tonen. Een tip is ook je webcam afdekken als je niet gefilmd wil worden. Maar als je toch het slachtoffer wordt, stap dan naar de politie en betaal vooral niet. Child Focus kan slachtoffers van sextortion bijstaan in de hele procedure. Ben je slachtoffer geworden of heb je hier vragen over, bel dan gerust het nummer van de hulplijn voor veilig internet van Child Focus 116 000, en wij zullen er alles aan doen om je verder te helpen. \r\n', 5, NULL, '2018-05-24 06:10:16', NULL),
(17, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 2, '2018-05-24 02:28:12', NULL, NULL),
(18, '30% in 1/2 jaar', 'De overgrote meerderheid van de vrouwen wordt regelmatig, soms dagelijks geconfronteerd met straatintimidatie. Volgens een recente studie van het Europese Fundamental Rights Agency verklaarden 60% van de Belgische vrouwen het slachtoffer geweest te zijn van seksuele intimidatie sinds de leeftijd van 15 jaar en 30% in de loop van de laatste 12 maanden.', 2, '2018-05-24 02:56:17', NULL, '2018-05-24 02:59:29'),
(19, 'Sextortion\'s, wat is dat?', 'test', 5, '2018-05-24 06:09:11', NULL, '2018-05-24 06:10:01');

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` int(10) UNSIGNED NOT NULL,
  `comment` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `user_id` int(10) UNSIGNED NOT NULL,
  `post_id` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `comment`, `user_id`, `post_id`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Mooi moi', 1, 1, '2018-05-30 08:39:50', '2018-05-30 08:41:10', '2018-05-30 08:41:10'),
(2, ':)', 1, 1, '2018-05-30 08:40:30', '2018-05-30 08:40:30', NULL),
(3, 'Het is al geruime tijd een bekend gegeven dat een lezer, tijdens het bekijken van de layout van een pagina, afgeleid wordt door de tekstuele inhoud. Het belangrijke', 2, 1, '2018-05-30 11:17:48', '2018-05-30 11:17:48', NULL),
(4, 'Het is al geruime tijd een bekend gegeven dat een lezer, tijdens het bekijken van de layout van een pagina, afgeleid wordt door de tekstuele inhoud. Het belangrijke', 1, 2, '2018-05-30 11:18:21', '2018-05-30 11:18:21', NULL),
(5, 'Het is al geruime tijd een bekend gegeven dat een lezer, tijdens het bekijken van de layout van een pagina, afgeleid wordt door de tekstuele inhoud. Het belangrijke', 4, 2, '2018-05-30 11:20:09', '2018-05-30 11:20:09', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `migrations`
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
-- Table structure for table `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `id` int(10) UNSIGNED NOT NULL,
  `title` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`id`, `title`, `description`, `user_id`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Testpost om eens te kijken naar styling weet je ;)', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting. Het is in de jaren \'60 populair geworden met de introductie van Letraset vellen met Lorem Ipsum passages en meer recentelijk door desktop publishing software zoals Aldus PageMaker die versies van Lorem Ipsum bevatten.', 1, '2018-05-30 08:29:59', '2018-05-30 08:29:59', NULL),
(2, 'Hier hebt ge u vraag', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting. Het is in de jaren \'60 populair geworden met de introductie van Letraset vellen met Lorem Ipsum passages en meer recentelijk door desktop publishing software zoals Aldus PageMaker die versies van Lorem Ipsum bevatten.', 2, '2018-05-30 11:17:28', '2018-05-30 11:17:28', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `quotes`
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
-- Dumping data for table `quotes`
--

INSERT INTO `quotes` (`id`, `quote`, `blokID`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, '\"Seksuele intimidatie zijn seksueel getinte gebaren, woorden, aanrakingen die je ongemakkelijk doen voelen.\" - Sensoa', 1, NULL, NULL, NULL),
(2, '\"Soms hebben mensen de kracht niet meer om het gevecht om rechtvaardigheid aan te gaan en dat is heel begrijpelijk.\" - InfoNu', 2, NULL, NULL, NULL),
(3, '\"Seksuele intimidatie hoeft niet per se lichamelijk te zijn.\" - Jobat', 3, NULL, NULL, '2018-05-24 03:53:08'),
(4, '\"Indien de seksuele intimidatie hinderlijk betasten is kan men ook spreken van aanranding.\" - Wikipedia', 4, NULL, '2018-05-17 04:23:36', NULL),
(5, 'Seksuele intimidatie op het werk en op andere openbare plaatsen kan ook bestraft worden op basis van de seksismewet. - Instituut voor de Gelijkheid van Vrouwen en Mannen', 3, '2018-05-24 03:55:15', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
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
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `lastName`, `email`, `username`, `password`, `is_admin`, `remember_token`, `created_at`, `updated_at`) VALUES
(1, 'Mark', 'Verhoeven', 'mark.verhoeven@gmail.com', 'Anoniempje', '$2y$10$c5qGcA19hfo.1THVjHHTmexX5Ac3JkkAN2FfnLrnCbT7F8Auio5jK', 0, '5n0b0HDo9EQsBESV6yntO5RDiGaO4RR2i99Rg4EXZughaWbmctHqysauGGWH', '2018-05-30 07:41:48', '2018-05-30 07:41:48'),
(2, 'Vincent', 'Van Minnebruggen', 'vincentvm98@hotmail.com', 'Tnecniv', '$2y$10$19lJJI0zr2udkS4KSr445eFsZ08J7.aXJRhMVlk..i9PNUIRw3naO', 0, 'hsKD8dcqGZ0AtE0ZU1wiPNFSJ3fJm4jGtizGZrAY5s1iEuEY8C0uErtv22P9', '2018-05-30 11:16:17', '2018-05-30 11:16:17'),
(4, 'Admin', 'Admin', 'admin@admin.be', 'admin', '$2y$10$YTJCrcAS.MVbQVD0nu2vCO.u3b7rBh2AfK1F32/iw7al.Yq6YHO/e', 1, NULL, '2018-05-30 11:19:45', '2018-05-30 11:19:45');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `comments_user_id_foreign` (`user_id`),
  ADD KEY `comments_post_id_foreign` (`post_id`);

--
-- Indexes for table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quotes`
--
ALTER TABLE `quotes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `articles`
--
ALTER TABLE `articles`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `quotes`
--
ALTER TABLE `quotes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_post_id_foreign` FOREIGN KEY (`post_id`) REFERENCES `posts` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `comments_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;
