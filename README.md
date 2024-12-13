<h1>Quiz Game: Code and Cry!</h1>
It's my first game project here on GH. Let's support me and donate, а то прям тяжко было.

**Лирическое отсутпление**
Это мой первый проект на C# Windows forms. Заметку эту пишу уже потратив на разработку более 20 часов, просто чтобы отвлечься. Работаю как извращенец с мака на удаленной винде (вините Билла Гейца за это), так что буду преимущественно на инглише писать, чтобы не мучаться с раскладкой.
So Let's dive into my simple silly game, that already have been completely rewriten thrice.

<h2>What’s Inside?</h2>

**1. Главная форма (Form1):**
- Authorization Button: логиньтесь и хз пока зачем. // canceled option. I'm not going to do this.
- Start Button: initiate game session. // done ✅
- Setting Button:<br>
 -- Ползунок "timer" – игра закончится, как только таймер дойдет до 00:00. Default: 9:59. // backlog <br>
 -- Select: "Сложность вопросов" (easy, hard, hell). Default: hard. Пока с уровнем вопросов не заморачивался, но нужно сделать как-нибудь. // done ✅<br>
 -- Multiselect: "Assistance" (50-50, Ask the Audience, etc.). Default: All Options. // done ✅<br>
 -- Радиобатоны "Music" и "Sound". Default: "on". // todo <br>
- Посмотреть результаты (Results): Check your shame (or glory). // backlog
- Exit Button: on click messageBox.Show "Why don't you play more, maggot?!" (2 seconds and shut down everything). // backlog

**2. Форма "game_session":**

- Badges? // in progress
- Progress Bar // done ✅
- Questions // done ✅
- 4 Answers ✅
- 6 Assistance.

**3. Форма "achievements":** // todo

- Header "Поздравляем, вы сделали что-то толковое! 🏆"
- Image
- Name
- Description

**4. Форма "game_session_end":** // todo

- Победили? 💸 "Congratulations! You've won $5000!"
- Проиграли? "Wrong answer! Final Score: 0."

<h2>🎮 Game Logic</h2> // done almost as planned ✅

1. Правильный ответ = money + eternal respect.
2. 7 correct answers >> ВСЁ БАБЛО ВАШЕ.
3. Награда за вопросы: // I'll add this later
- Вопросы 1–3: $100 каждый.
- Вопросы 4–5: $500 каждый.
- Вопросы 6–7: $1000 каждый.
4. Timer is ran out OR incorrect answer >> GAME OVER.

<h2>🛠 Assistance Logic</h2> // done ✅ but a simplier version.
When your ass needs to be saved:

1. 50-50: убирает два неправильных ответа.
2. Ask the Audience: 90% шанс, что толпа угадает верно. Но с каждым правильным ответом шанс уменьшается.
3. Call a Stupid Friend: всегда угадывает неправильно.
4. Call Your Lawyer: выбирает между правильным и неправильным (почти как 50-50, но юридически).
5. Toss a d4 Dice: total chaos, like life itself.
6. Ask ChatGPT: 75% chance to get it right.

=====
<h3>🛠 Extended Version Features</h3>
- Темы "Day/Night".
<br>- Бэкграундная музыка. // done ✅
<br>- Эффекты на события. // done ✅
<br>- Ачивки и история игры.
<br>- display on Form1 score lable and other usefull stuff. // done ✅ I added a progressbar
<br>- Random question Selection // done ✅

<h3>🚀 Backlog (Future Stuff)</h3>
- Question Database Integration (только хардкор!).
<br>- Authorization & Email Verification.
<br>- Multiplayer: быстрее всех жмите красную кнопку!
<br>- Сложность ответов. // done ✅
<br>- Рандомизация ответов.
<br>- Error handlers 


