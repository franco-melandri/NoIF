fun main(args: Array<String>) {

    for (i in 1..100) {
        println(fizzBuzzNoIF(i))
    }
}


fun fizzBuzzIF(value: Int): String {

    return when {
        (value % 3 == 0 && value % 5 == 0) -> "FizzBuzz"
        value % 3 == 0 -> "Fizz"
        value % 5 == 0 -> "Buzz"
        else -> value.toString()
    }
}


private val dataset = mapOf(
        { i: Int -> i % 3 == 0 } to "Fizz",
        { i: Int -> i % 5 == 0 } to "Buzz"
)

fun fizzBuzzNoIF(value: Int) =
        dataset.filter { it.key(value) }
                .values
                .takeIf { it.isNotEmpty() }
                ?.fold("") { acc, new -> acc + new } ?: value.toString()