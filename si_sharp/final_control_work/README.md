Итоговая работа по основному блоку
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Описана функция CreateArray() для создания исходного массива с получением данных от пользователя. 
Описана функция ShowArray() для вывода массива в консоль. 
Описана функция ResultArray() по блок-схеме, которая непосредственно выполняет поставленную задачу. 
Описание вызова функций. 

Блок схема 
https://viewer.diagrams.net/?highlight=0000ff&edit=_blank&nav=1&title=image.png#R5Vtdc6M2FP01fkwG8c1jPpxsO21nZzLTdh9l0GI2gFwhx3Z%2BfQUIAxK2yQaDvH4yXAlhnXt87tWVPDMeku0zgavlnzhA8UzXgu3MeJzpOgCGyT5yy6606LoHSktIooD3qg0v0TviRo1b11GAslZHinFMo1Xb6OM0RT5t2SAheNPu9h3H7beuYIgkw4sPY9n6TxTQZWl1dae2f0FRuKzeDGyvbElg1ZnPJFvCAG8aJmM%2BMx4IxrS8SrYPKM7Rq3Apn3s60Lr%2FYgSltM8DrxsYBj59ep1%2Fg%2F%2F55lNw9%2FzXTTWPjO6qGaOAAcBvMaFLHOIUxvPaek%2FwOg1QPqzG7uo%2Bf2C8YkbAjD8QpTvuTbimmJmWNIl5K%2FvGZPcvf764%2BZbf3FrV7eO22fi4a959RSRKEEWEG2UcODT5RBoGjsozwuxpsmMdCIohjd7anoacMOG%2BH3%2F0jhC4a3RY4SilWWPkr7mBdeDkN4BRjsip7wDBP0J%2FoFmf6m%2B2%2Fc8uym%2Fc%2FbRudj%2B9nx6FJESUP9UatoFhbSrI1k283%2Bfa7rfEtRdv9%2B9%2Fv6TIyeaPN4AT7w3Ga%2B6AKZh4kDwZXhMfHZkAd24J05F%2B5tBkbHnio7AbEuoZmwGVoK%2BBzVHaLCOKXlawAGTDlL4niG%2BIULQ9Om3eamstNt4AYHHLplZdUHF02VBcWzsTVMC9cIaaPRlqKcVQU0IdFjJm3c%2BsR8kBLKiu8kuGD4xjFOOQwIShtmoEiVZbI3qcovX3aIuqjGQgmpsizTVzcpp7F05zqyfNbaVobkmoR%2By2uNKYq%2B2YTeV%2BQdhVmF%2F5xxoXzcaDQq6NIuSWwHBPn5rg1csuluB2T4I7ShFct68E9mqlqgjuMuyFsOg2TPJfeyEd5doY7m5jlOY%2FQEk0ljhZrLNRBMMQBMPxOgTD7hAM92yCASQIL4u5Tk%2FmukoRt0L5l4fdUwp2eR1e5dsRS7j3CiEqSJFuGJMqh5RNTy8d8pKxSNx0jheYFC9TPbzktUd0Aq%2BR01mpMOG6k%2Bezl145Gz5hOlAgBe0S543ljFzjlFceKdpUyRdTWL%2BrpDH1is12vFtrao4rXns7O3U9kbqGAHX5KzsbdQ25UKyUA06vygavavYUGdMb11O64vW7czvA1Kb%2BqcgVa6UccDoe962gArVKqECuofYIrxe2Y2CJ8mJMnX8CucKE0uBIGjPODqKYxhiTA6X3EYY0uMtPqbA7P4ZZFvltYNqysD83sT9E0e%2FcxM%2BH0b61igbIVgfGle2TWm%2BBfWoqrWFPqL08li4QxrP6rQ4%2Beg5EepFrHTmoMVhaIIvjJ8n38xF%2BHHLIS3VLq9jyUXIAII4lJhUDkQO4B150VnIYXZFT3gZgykvbjIBxFKY5XRgHioCY63Pkw%2FiONyRREJT5DMqid7gohsrZw4Fg45Yb%2BWwslsJkdazMKMGv6AHHOI%2FAKU5REVDjWDANECoMcc%2FBBboUK8wOpookGO5YjhxTA3g1%2FgCe4A%2FHndofco3tivxhiurneBP7w%2BwTzVReYxk8kTp9XFCt3WRDri4ovp18qOY72R6HeekHISpKnubu4CWfzx2xuvSDP%2F2B15UC3pSBv5w9ZfX0Qz6O0i5zLYoyFz8B2ARaPikYzBTajVYPaf1AsFNoO1oAzbY7QBu1ymX22SlSvMrVWz9HKnPppljmkrau%2B5e5xILZmSoZ0ovsMSoZ5uA11oMsUoQcsgQYw5W5bHAecgBX%2FNJgDHJc9Sp%2B%2F2%2BAvYZ0xIpxV%2FHyqY4r8oe8UT25P%2BTF%2FVWVgcWNGcvzzuUQdlv%2F07vUt%2FoP88b8fw%3D%3D
