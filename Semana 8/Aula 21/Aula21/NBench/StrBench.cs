using System;

public static class StrBench {

    private static readonly String[] GREEK_CHARS = new String[]
    {
        "Alpha", "Beta", "Gamma", "Delta", "Epsilon",
        "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda",
        "Mu", "Nu", "Xi", "Omicron", "Pi", "Rho", "Sigma",
        "Tau", "Upsilon", "Phi", "Chi", "Psi", "Omega"
    };

    public static Object noJoin() {
		return null;
    }

    public static Object testJoinWithPlus() {
		return StrJoins.JoinWithPlus(GREEK_CHARS);
    }

    public static Object testJoinWithBuilder() {
		return StrJoins.JoinWithBuilder(GREEK_CHARS);
    }

    public static Object testJoinWithJoin() {
		return StrJoins.JoinWithJoin(GREEK_CHARS);
    }

	public static void Main()
	{
		const long ITER_TIME  = 1000;
		const long NUM_WARMUP = 10;
		const long NUM_ITER   = 10;

		NBench.Benchmark(new BenchmarkMethod(StrBench.noJoin), "noJoin", ITER_TIME, NUM_WARMUP, NUM_ITER);
		NBench.Benchmark(new BenchmarkMethod(StrBench.testJoinWithPlus), "JoinWithPlus", ITER_TIME, NUM_WARMUP, NUM_ITER);
		NBench.Benchmark(new BenchmarkMethod(StrBench.testJoinWithBuilder), "JoinWithBuilder", ITER_TIME, NUM_WARMUP, NUM_ITER);
		NBench.Benchmark(new BenchmarkMethod(StrBench.testJoinWithJoin), "JoinWithJoin", ITER_TIME, NUM_WARMUP, NUM_ITER);
	}
}


/*
:: BENCHMARKING noJoin ::
# Warmup Iteration  1: 297973600 ops/s      3.36 ns
# Warmup Iteration  2: 305636384 ops/s      3.27 ns
# Warmup Iteration  3: 305006528 ops/s      3.28 ns
# Warmup Iteration  4: 302660672 ops/s      3.30 ns
# Warmup Iteration  5: 300018432 ops/s      3.33 ns
# Warmup Iteration  6: 310157920 ops/s      3.22 ns
# Warmup Iteration  7: 310601888 ops/s      3.22 ns
# Warmup Iteration  8: 311848672 ops/s      3.21 ns
# Warmup Iteration  9: 309457920 ops/s      3.23 ns
# Warmup Iteration 10: 311830720 ops/s      3.21 ns
Iteration  1: 309103232 ops/s       3.24 ns
Iteration  2: 311434624 ops/s       3.21 ns
Iteration  3: 309624032 ops/s       3.23 ns
Iteration  4: 305860448 ops/s       3.27 ns
Iteration  5: 307430016 ops/s       3.25 ns
Iteration  6: 308409088 ops/s       3.24 ns
Iteration  7: 308279968 ops/s       3.24 ns
Iteration  8: 308030752 ops/s       3.25 ns
Iteration  9: 307337600 ops/s       3.25 ns
Iteration 10: 305114432 ops/s       3.28 ns

Result: 311434624 ops/s     3.21 ns


:: BENCHMARKING JoinWithPlus ::
# Warmup Iteration  1: 289280 ops/s  3456.86 ns
# Warmup Iteration  2: 297120 ops/s  3365.64 ns
# Warmup Iteration  3: 304512 ops/s  3283.94 ns
# Warmup Iteration  4: 299872 ops/s  3334.76 ns
# Warmup Iteration  5: 304384 ops/s  3285.32 ns
# Warmup Iteration  6: 301952 ops/s  3311.78 ns
# Warmup Iteration  7: 309280 ops/s  3233.32 ns
# Warmup Iteration  8: 309024 ops/s  3235.99 ns
# Warmup Iteration  9: 302592 ops/s  3304.78 ns
# Warmup Iteration 10: 304288 ops/s  3286.36 ns
Iteration  1: 299584 ops/s   3337.96 ns
Iteration  2: 308064 ops/s   3246.08 ns
Iteration  3: 308096 ops/s   3245.74 ns
Iteration  4: 304256 ops/s   3286.71 ns
Iteration  5: 299744 ops/s   3336.18 ns
Iteration  6: 301056 ops/s   3321.64 ns
Iteration  7: 302784 ops/s   3302.68 ns
Iteration  8: 304160 ops/s   3287.74 ns
Iteration  9: 297536 ops/s   3360.94 ns
Iteration 10: 302496 ops/s   3305.83 ns

Result: 308096 ops/s     3245.74 ns


:: BENCHMARKING JoinWithBuilder ::
# Warmup Iteration  1: 1013792 ops/s      986.40 ns
# Warmup Iteration  2: 998208 ops/s  1001.80 ns
# Warmup Iteration  3: 1015648 ops/s      984.59 ns
# Warmup Iteration  4: 993152 ops/s  1006.90 ns
# Warmup Iteration  5: 1019424 ops/s      980.95 ns
# Warmup Iteration  6: 1029728 ops/s      971.13 ns
# Warmup Iteration  7: 1027551 ops/s      973.19 ns
# Warmup Iteration  8: 1028352 ops/s      972.43 ns
# Warmup Iteration  9: 1021920 ops/s      978.55 ns
# Warmup Iteration 10: 1027008 ops/s      973.70 ns
Iteration  1: 957056 ops/s   1044.87 ns
Iteration  2: 922272 ops/s   1084.28 ns
Iteration  3: 1010816 ops/s   989.30 ns
Iteration  4: 1010912 ops/s   989.21 ns
Iteration  5: 1006816 ops/s   993.23 ns
Iteration  6: 1031647 ops/s   969.32 ns
Iteration  7: 1036896 ops/s   964.42 ns
Iteration  8: 1028640 ops/s   972.16 ns
Iteration  9: 1018944 ops/s   981.41 ns
Iteration 10: 1035520 ops/s   965.70 ns

Result: 1036896 ops/s     964.42 ns


:: BENCHMARKING JoinWithJoin ::
# Warmup Iteration  1: 1410304 ops/s      709.07 ns
# Warmup Iteration  2: 1411968 ops/s      708.23 ns
# Warmup Iteration  3: 1408096 ops/s      710.18 ns
# Warmup Iteration  4: 1405536 ops/s      711.47 ns
# Warmup Iteration  5: 1408864 ops/s      709.79 ns
# Warmup Iteration  6: 1407072 ops/s      710.70 ns
# Warmup Iteration  7: 1408128 ops/s      710.16 ns
# Warmup Iteration  8: 1412000 ops/s      708.22 ns
# Warmup Iteration  9: 1415968 ops/s      706.23 ns
# Warmup Iteration 10: 1420992 ops/s      703.73 ns
Iteration  1: 1432224 ops/s   698.21 ns
Iteration  2: 1428512 ops/s   700.03 ns
Iteration  3: 1396928 ops/s   715.86 ns
Iteration  4: 1414112 ops/s   707.16 ns
Iteration  5: 1421632 ops/s   703.42 ns
Iteration  6: 1423360 ops/s   702.56 ns
Iteration  7: 1402144 ops/s   713.19 ns
Iteration  8: 1404768 ops/s   711.86 ns
Iteration  9: 1416416 ops/s   706.01 ns
Iteration 10: 1386848 ops/s   721.06 ns

Result: 1432224 ops/s     698.21 ns

*/
