# 🌡 TwoDimensionalCellularAutomaton

Simulation of a **two-dimensional cellular automaton** with temperature-based cell states and movement.  
Симуляция **двухмерного клеточного автомата** с тепловыми состояниями клеток и возможностью их перемещения.

---

## 📌 About / О проекте

🎓 Developed as a modeling experiment for cell population dynamics and heat exchange.  
💡 Combines **temperature evolution** and **cell movement** using Moore neighborhood.  
🌈 Color-coded grid representing temperature from very cold (blue) to very hot (red).

🎓 Разработано как эксперимент моделирования динамики популяции клеток и теплообмена.  
💡 Объединяет **изменение температуры** и **перемещение клеток** с использованием окрестности Мура.  
🌈 Цветовая кодировка поля — от очень холодных (синих) до перегретых (красных) клеток.

---

## 🔧 Features / Возможности

- 📏 Adjustable grid size (1×1 to 100×100)  
  Регулируемый размер поля (от 1×1 до 100×100)

- 🌱 Adjustable initial density of live cells (via slider)  
  Регулируемая начальная плотность живых клеток (ползунок)

- 🎨 Temperature-based color scale / Цветовая шкала по температуре:  
  - 🔵 Very cold (≤ −40°C) → blue / Очень холодный (≤ −40°C) → синий  
  - ⚪ Neutral (~0°C) → gray / Нейтральный (~0°C) → серый  
  - 🔴 Very hot (≥ 90°C) → red / Очень горячий (≥ 90°C) → красный

- ♻ Moore neighborhood for interaction (8 surrounding cells)  
  Окрестность Мура для взаимодействий (8 соседних клеток)

- 🚶 Cells can move into empty neighbors, heating or cooling depending on surroundings  
  Клетки могут перемещаться в пустые соседние ячейки, нагреваясь или охлаждаясь в зависимости от окружения

- ❄ Frozen cells stop moving; overheated cells disappear  
  Замёрзшие клетки перестают двигаться; перегретые исчезают

- ⏯ Start/Stop and Reset controls  
  Кнопки запуска/остановки и сброса симуляции

- ⏱ Stopwatch and generation counter  
  Секундомер и счётчик поколений

---

## 📁 Structure / Структура

- `Form1.cs` — main form logic, initialization, simulation loop, state calculation, drawing  
  Основная форма: инициализация, цикл симуляции, расчёт состояния, отрисовка

---

## 🖼 Screenshots / Скриншоты

![Программа](images/application.gif) *Рис. 1 — Пример работы программы*

---

## 📐 Model Description / Описание модели

**Cell states / Состояния клеток:**  
- **Empty (0) / Пустая (0)** — white / белая  
- **Live (>0) / Живая (>0)** — temperature determines color / цвет зависит от температуры  
- **Frozen (< -119) / Замёрзшая (< -119)** — stops moving, blue / перестаёт двигаться, синяя  
- **Overheated (>299) / Перегретая (>299)** — removed from grid / исчезает с поля

**Temperature change rules / Правила изменения температуры:**  
- Neighbor present → +35°C heating  
  Есть сосед → нагрев на +35°C  
- Neighbor absent → −4°C cooling  
  Нет соседа → охлаждение на −4°C  
- Possible move found → +20…40°C extra heating  
  Есть возможность перемещения → дополнительный нагрев на +20…40°C

**Movement rule / Правило перемещения:**  
If free neighboring cells exist (Moore neighborhood), a cell may move to one of them randomly.  
Если существуют свободные соседние клетки (окрестность Мура), клетка может случайным образом переместиться в одну из них.
---
