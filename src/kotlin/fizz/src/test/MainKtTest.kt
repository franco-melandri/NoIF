package test

import fizzBuzzIF
import fizzBuzzNoIF
import org.junit.jupiter.api.Test

internal class MainKtTest {

    @Test
    fun shouldResolveFizzBuzzIF() {

        assert(fizzBuzzIF(1) == "1")
        assert(fizzBuzzIF(3) == "Fizz")
        assert(fizzBuzzIF(5) == "Buzz")
        assert(fizzBuzzIF(3*5) == "FizzBuzz")

    }


    @Test
    fun shouldResolveFizzBuzzNoIF() {

        assert(fizzBuzzNoIF(1) == "1")
        assert(fizzBuzzNoIF(3) == "Fizz")
        assert(fizzBuzzNoIF(5) == "Buzz")
        assert(fizzBuzzNoIF(3*5) == "FizzBuzz")
    }
}